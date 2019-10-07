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

namespace Wellness.WinUI
{
    public partial class frmCameraQRDecoder: MetroForm
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        QRCodeHelper QRCodeHelper;
        private int _ticks=0;
        private int _falseResult=0;
        private int _trueResult=0;

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
        }


        /*
               Imaju cetri moguca rezultata

               1.QR Kod nije prepoznatljiv
               2.QR Kod se ne moze ocitat
               3.QR Kod je prepoznat i sve je u redu u vezi clanarina
               4.QR Kod je prepoznat ali clan ima ne podmirenih obaveza
               */


        private async void Timer1_Tick(object sender, EventArgs e)
        {
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
                        if (DateTimeUsporedni > clanarina.Paket.VrijemePristupaOd && DateTimeUsporedni < clanarina.Paket.VrijemePristupaDo)
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

        private void FinalFrame_NewFrame(object sender,NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void BtnTraziQR_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();

        }

        private void FrmCameraQRDecoder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(FinalFrame.IsRunning==true)
            {
                FinalFrame.Stop();
            }
        }

        private void BtnZaustavi_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Beep_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
        }



        private void Timer2_Tick(object sender, EventArgs e)
        {
            CameraStartSetup();

        }


        void CameraStopSetup(string textMain, string textSide)
        {
            timer1.Stop();
            timer2.Start();
            lblMain.Text = textMain;
            lblSide.Text = textSide;

            panelPictureBox.Visible = false;

        }
        void CameraStartSetup()
        {
            timer1.Start();
            timer2.Stop();
            lblMain.Text = "";
            lblSide.Text = "";
            panelPictureBox.BackColor = Color.Empty;
            panelPictureBox.Visible = true;
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
        }
    }
}
