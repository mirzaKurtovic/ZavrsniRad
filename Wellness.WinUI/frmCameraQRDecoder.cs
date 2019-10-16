using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using AForge;

using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using Wellness.Model.Requests;
using System.Media;
using MetroFramework.Forms;
using AForge.Vision.Motion;
using System.Timers;
using System.Threading;

namespace Wellness.WinUI
{
    public partial class frmCameraQRDecoder : Form
    {

        private delegate void SafeCallDelegate(string text);

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        MotionDetector detector;
        bool SkeniranjeUToku = false;
        int positiveResults = 0;


        System.Timers.Timer timerDecodingTotal;


        BetterTimer timer = new BetterTimer();




        QRCodeHelper QRCodeHelper;
        private int _ticks = 0;
        private int _falseResult = 0;
        private int _trueResult = 0;

        private string textMain = "";
        private string textSide = "";

        private string BeepNotOK = @"C:\Users\Mirza\source\repos\ZavrsniRad\Sounds\NotOK.wav";
        private string BeepOK = @"C:\Users\Mirza\source\repos\ZavrsniRad\Sounds\OK.wav";

        

        //private string BeepOK = @"..\Sounds\NotOK.wav";
        //private string BeepNotOK = @"..\Sounds\NotOK.wav";
        //src="~/images/image.jpg"
        //"C:\Users\Mirza\source\repos\ZavrsniRad\Sounds\NotOK.wav"

        private readonly APIService _apiService_Clan = new APIService("Clan");
        private readonly APIService _apiService_Clanarina = new APIService("Clanarina");
        private readonly APIService _apiService_Paket = new APIService("Paket");
        private readonly APIService _apiService_PaketPristupniDani = new APIService("PaketPristupniDani");
        public frmCameraQRDecoder()
        {
            InitializeComponent();
        }

        private void FrmCameraQRDecoder_Load(object sender, EventArgs e)
        {
            #region motionDetectionSetup
            // create motion detector
                detector = new MotionDetector(
                new SimpleBackgroundModelingDetector(),
                new MotionAreaHighlighting());





            #endregion motionDetectionSetup

            #region init
            panelPictureBox.BackColor = Color.Green;
            lblMain.Text = "";
            lblSide.Text = "";

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            QRCodeHelper = new QRCodeHelper();
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();



            #endregion init

            #region timersSetup
            timer.Interval = 250;
            timer.Tick += new EventHandler(timer_Tick);
            
            timerDecodingTotal = new System.Timers.Timer(5000);
            timerDecodingTotal.Elapsed += new ElapsedEventHandler(timerDecodingTotal_Elapsed);
            #endregion timersSetup
        }

        //pokretanje dekodiranja na osnovu video kamere
        private  void  timerDecodeOnce_Elapsed(object sender, ElapsedEventArgs e)
        {
           //...
            
        }
        async void timer_Tick(object sender, EventArgs e)
        {
            await tick();
            //lblTrenutnaRadnja.Text = "eso";
        }
        //zaustavljanje dekodiranja nakon odredjenog intervala...
        private void timerDecodingTotal_Elapsed(object sender, ElapsedEventArgs e)
        {
            SkeniranjeUToku = false;
            timer.Enabled = false;
            timerDecodingTotal.Enabled = false;
        }




        private async Task tick()
        {
                    /*
               Imaju cetri moguca rezultata

               1.QR Kod nije prepoznatljiv
               2.QR Kod se ne moze ocitat
               3.QR Kod je prepoznat i sve je u redu u vezi clanarina
               4.QR Kod je prepoznat ali clan ima ne podmirenih obaveza
               */


            _ticks++;
            var text = QRCodeHelper.DecodeQRCode(pictureBox1.Image);
            if (String.IsNullOrEmpty(text))
            {
                _falseResult++;
                txtNegative.Text = _falseResult.ToString();
            }
            else
            {
                _trueResult++;
                txtPositive.Text = _trueResult.ToString();

                

                var ClanSearchRequest = new Model.Requests.ClanSearchRequest()
                {
                    QrCodeText = text
                };

                var list = await _apiService_Clan.Get<List<ClanViewRequest>>(ClanSearchRequest);



                //1.QR Kod nije prepoznatljiv
                if (list.Count == 0)
                {
                    textMain = "Pristup ogranicen";
                    textSide = "QR kod koji ste prikazali nije prepoznatljiv ! ";
                    CameraStopSetup(textMain, textSide);
                    PanelRed();
                    playBeep(BeepNotOK);
                    return;
                }

                var clan = list.FirstOrDefault();




                //2.QR Kod se ne moze ocitat
                //event se pozove nakon 10 sekundi.. iznad



                //3.QR Kod je prepoznat i sve je u redu u vezi clanarina
                //4.QR Kod je prepoznat ali clan ima ne podmirenih obaveza
                //Prvo korisnik treba imati clanarinu za dati mjesec i godinu, zatim
                if (clan != null)
                {
                    DateTime dateTime = DateTime.Now;
                    var DanUSedmici = dateTime.DayOfWeek;
                    var DanUSedmiciString = "";
                    bool pristupDatimDanomOdobren = false;
                    switch (Convert.ToInt32(DanUSedmici))
                    {
                        case 0: { DanUSedmiciString = "Nedjelja"; } break;
                        case 1: { DanUSedmiciString = "Ponedjeljak"; } break;
                        case 2: { DanUSedmiciString = "Utorak"; } break;
                        case 3: { DanUSedmiciString = "Srijeda"; } break;
                        case 4: { DanUSedmiciString = "Cetvrtak"; } break;
                        case 5: { DanUSedmiciString = "Petak"; } break;
                        case 6: { DanUSedmiciString = "Subota"; } break;
                        default: { DanUSedmiciString = "Nepoznato"; } break;
                    }

                    var clanarinaSearchRequest = new ClanarinaSearchRequest()
                    {
                        ClanID = clan.Id,
                        UplataZaGodinu = dateTime.Year,
                        UplataZaMjesec = dateTime.Month
                    };
                    var clanarinaList = await _apiService_Clanarina.Get<List<Model.Clanarina>>(clanarinaSearchRequest);
                    if (clanarinaList.Count == 0)
                    {
                        textMain = "Pristup ogranicen";
                        textSide = "Niste uplatili clanarinu za " + dateTime.Month + ". mjesec " + dateTime.Year + ". godine";
                        CameraStopSetup(textMain, textSide);
                        PanelRed();
                        playBeep(BeepNotOK);

                        return;
                    }
                    var clanarina = clanarinaList[0];
                    var paketPristupniDaniSearchRequest = new PaketPristupniDaniSearchRequest()
                    {
                        PaketId = clanarina.Paket.Id,
                    };
                    var paketPristupniDaniList = await _apiService_PaketPristupniDani.Get<List<Model.PaketPristupniDani>>(paketPristupniDaniSearchRequest);//vraca 0 rezultata


                    //Gledamo ima li pristup datim danima
                    foreach (Model.PaketPristupniDani x in paketPristupniDaniList)
                    {
                        if (DanUSedmiciString == x.PristupniDani.DanUSedmici)
                        {
                            pristupDatimDanomOdobren = true;
                            break;
                        }
                    }


                    if (pristupDatimDanomOdobren == false)
                    {
                        textMain = "Pristup ogranicen";
                        textSide = "Nemate pristup Fitness centru ovim danom(" + DanUSedmiciString + ")";
                        CameraStopSetup(textMain, textSide);
                        PanelRed();
                        playBeep(BeepNotOK);
                        return;
                    }
                    else
                    {
                        //Gledamo ima li pristup u datom vremenskom intervalu
                        var paketList = await _apiService_Paket.Get<List<Model.Paket>>(new PaketSearchRequest() { Id = clanarina.PaketId });
                        var paket = paketList[0];
                        if (paket.NeogranicenPristup == true)
                        {
                            textMain = "Pristup odobren";
                            textSide = "Dobro došli";
                            CameraStopSetup(textMain, textSide);
                            PanelGreen();
                            playBeep(BeepOK);
                            return;
                        }

                        var DateTimeUsporedni = new DateTime(clanarina.Paket.VrijemePristupaOd.Value.Year,
                            clanarina.Paket.VrijemePristupaOd.Value.Month,
                            clanarina.Paket.VrijemePristupaOd.Value.Day,
                            dateTime.Hour,
                            dateTime.Minute,
                            clanarina.Paket.VrijemePristupaOd.Value.Second,
                            clanarina.Paket.VrijemePristupaOd.Value.Millisecond);
                        if (DateTimeUsporedni > clanarina.Paket.VrijemePristupaOd && clanarina.Paket.VrijemePristupaDo > DateTimeUsporedni)
                        {
                            textMain = "Pristup odobren";
                            textSide = "Dobro došli";
                            CameraStopSetup(textMain, textSide);
                            PanelGreen();
                            playBeep(BeepOK);
                            return;
                        }
                        else
                        {
                            textMain = "Pristup ogranicen";
                            textSide = "Nemate pristup Fitness centru u terminu od " + clanarina.Paket.VrijemePristupaOd.Value.ToShortTimeString() + " do " + clanarina.Paket.VrijemePristupaDo.Value.ToShortTimeString();
                            CameraStopSetup(textMain, textSide);
                            PanelRed();
                            playBeep(BeepNotOK);
                            return;
                        }
                    }
                }
            }
            txtTotal.Text = _ticks.ToString();
        }

        private void BtnPokreni_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            var videoFrame = (Bitmap)eventArgs.Frame.Clone();

            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();


            //process new video frame and check motion level
            if (SkeniranjeUToku == false)
            {
                if (detector.ProcessFrame(videoFrame) > 0.25)
                {
                    positiveResults++;
                    if (positiveResults >= 15)
                    {
                        positiveResults = 0;
                        SkeniranjeUToku = true;
                        timerDecodingTotal.Enabled = true;

                        timer.Enabled = true;
                    }
                }
            
            }
            //if (lblTrenutnaRadnja.Text != "Detekcija pokreta")
            //    lblTrenutnaRadnja.Text = "Detekcija pokreta";
            //else
            //{
            //    if (lblTrenutnaRadnja.Text != "Detekcija QR koda")
            //        lblTrenutnaRadnja.Text = "Detekcija QR koda";
            //}
        }

        private void FrmCameraQRDecoder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private void BtnZaustavi_Click(object sender, EventArgs e)
        {
            SkeniranjeUToku = false;
            timerDecodingTotal.Enabled = false;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            CameraStartSetup();
        }





        void CameraStopSetup(string textMain, string textSide)
        {
            timer2.Start();
            lblMain.Text = textMain;
            lblSide.Text = textSide;

            panelPictureBox.Visible = false;


            timerDecodingTotal.Enabled = false;
            timer.Enabled = false;

        }
        void CameraStartSetup()
        {
            timer2.Stop();

            lblMain.Text = "";
            lblSide.Text = "";

            panelPictureBox.BackColor = Color.Empty;
            panelPictureBox.Visible = true;

            SkeniranjeUToku = false;
        }



        void PanelGreen()
        {
            panelPictureBox.BackColor = Color.Green;
        }
        void PanelRed()
        {
            panelPictureBox.BackColor = Color.Red;
        }
        void playBeep(string soundLocation)
        {
            //"C:\Users\Mirza\source\repos\ZavrsniRad\Sounds\NotOK.wav"
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundLocation);
            player.Play();
        }
        private void BtnSakriPostavke_Click(object sender, EventArgs e)
        {
            gbPostavkeSkenera.Visible = false;
            sizeChanged();
        }
        private void FrmCameraQRDecoder_SizeChanged(object sender, EventArgs e)
        {
            sizeChanged();
        }
        void sizeChanged()
        {
            panelPictureBox.Location = new System.Drawing.Point(0, 0);
            panelPictureBox.Height = panelPictureBox.Parent.Height;
            panelPictureBox.Width = panelPictureBox.Parent.Width;

            pictureBox1.Height = pictureBox1.Parent.Height;
            pictureBox1.Width = pictureBox1.Parent.Width;
        }






    }
}


public class BetterTimer : System.Windows.Forms.Timer
{
    public BetterTimer() : base()
    { base.Enabled = true; }

    public BetterTimer(System.ComponentModel.IContainer container) : base(container)
    { base.Enabled = true; }

    private bool _Enabled;
    public override bool Enabled
    {
        get { return _Enabled; }
        set { _Enabled = value; }
    }

    protected override void OnTick(System.EventArgs e)
    { if (this.Enabled) base.OnTick(e); }
}