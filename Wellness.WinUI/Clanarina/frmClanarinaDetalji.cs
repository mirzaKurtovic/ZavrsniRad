using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Wellness.Model;
using Wellness.Model.Requests;

namespace Wellness.WinUI.Clanarina
{
    public partial class frmClanarinaDetalji : Form
    {
        private readonly APIService _apiService = new APIService("Clanarina");
        private readonly APIService _apiService_Clan = new APIService("Clan");
        private readonly APIService _apiService_Paket = new APIService("Paket");


        private readonly Validation _validation = new Validation();

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        QRCodeHelper QRCodeHelper;

        private readonly int? _id;
        public frmClanarinaDetalji(int? id = null)
        {
            _id = id;

            InitializeComponent();
        }

        private async void FrmClanarinaDetalji_Load(object sender, EventArgs e)
        {
            #region cameraSetup
            QRCodeHelper = new QRCodeHelper();
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            FinalFrame = new VideoCaptureDevice();
            pbQRKod.SizeMode = PictureBoxSizeMode.StretchImage;
            #endregion cameraSetup

            setScannerVisible(false);


            var clanovi = await _apiService_Clan.Get<List<Model.Requests.ClanViewRequest>>(null);
            cbClan.DataSource = clanovi;
            cbClan.DisplayMember = "Display";
            cbClan.ValueMember = "Id";
            cbClan.DropDownStyle = ComboBoxStyle.DropDownList;
            var defaultPaket = new Model.Paket()
            {
                Id = 0,
                Naziv = "svi"
            };
            var paketi = await _apiService_Paket.Get<List<Model.Paket>>(null);
            cbPaket.DataSource = paketi;
            cbPaket.DisplayMember = "Display";
            cbPaket.ValueMember = "Id";
            cbPaket.DropDownStyle = ComboBoxStyle.DropDownList;


            if (_id.HasValue)
            {
                var clanarina = await _apiService.GetById<Model.Clanarina>(_id);

                txtUplataZaGodinu.Text = clanarina.UplataZaGodinu.ToString();
                txtUplataZaMjesec.Text = clanarina.UplataZaMjesec.ToString();
                nudIznos.Value = clanarina.IznosUplate;
                dateDatumUplate.Value = clanarina.DatumUplate;
                cbPaket.SelectedValue = clanarina.PaketId;
                cbClan.SelectedValue = clanarina.ClanId;

                //treba dodati paket i korisnika
            }

        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = new ClanarinaInsertRequest()
                {
                    UplataZaMjesec = int.Parse(txtUplataZaMjesec.Text),
                    UplataZaGodinu = int.Parse(txtUplataZaGodinu.Text),
                    //IznosUplate = double.Parse(txtIznos.Text),
                    IznosUplate = (double)nudIznos.Value,
                    DatumUplate = dateDatumUplate.Value,
                    PaketID = (int)cbPaket.SelectedValue,
                    ClanID = (int)cbClan.SelectedValue
                };

                if (_id.HasValue)
                {

                    await _apiService.Update<Model.Clanarina>(_id, request);
                    MessageBox.Show("Uspjesno ste azurirali clanarinu", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    await _apiService.Insert<Model.Clanarina>(request);
                    MessageBox.Show("Uspjesno ste evidentirali novu clanarinu", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }

        }

        private void TxtUplataZaMjesec_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_validation.Required(sender, e, ClanarineErrorProvider))
                if (_validation.IsNumberOnly(sender, e, ClanarineErrorProvider))
                    _validation.MinMaxValue(sender, e, ClanarineErrorProvider, 1, 12);


        }

        private void TxtUplataZaGodinu_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_validation.Required(sender, e, ClanarineErrorProvider))
                if (_validation.IsNumberOnly(sender, e, ClanarineErrorProvider))
                    _validation.MinMaxValue(sender, e, ClanarineErrorProvider, 2000, 2100);
        }

        private void FrmClanarinaDetalji_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;

            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            setScannerVisible(true);
        }

        private void BtnZatvoriSkener_Click(object sender, EventArgs e)
        {
            setScannerVisible(false);
            timer1.Stop();
        }

        private async void Timer1_Tick(object sender, EventArgs e)
        {
            if (pbQRKod.Image == null)
                return;
            var text = QRCodeHelper.DecodeQRCode(pbQRKod.Image);
            if (!String.IsNullOrEmpty(text))
            {
                var ClanSearchRequest = new Model.Requests.ClanSearchRequest()
                {
                    QrCodeText = text
                };

                var list = await _apiService_Clan.Get<List<ClanViewRequest>>(ClanSearchRequest);
                if (list.Count != 0)
                {
                    var clanId = list[0].Id;
                    cbClan.SelectedValue = clanId;
                    timer1.Stop();
                    MessageBox.Show(list[0].Display,"Korisnik pronadje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //doradit messagebox

                }
                else
                {
                     MessageBox.Show("QR Kod nije validan", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                setScannerVisible(false);
            }

        }

        private void BtnOdaberiKameru_Click(object sender, EventArgs e)
        {
            if(comboBox1.Items.Count<=0)
            {
                MessageBox.Show("Za skeniranje QR koda potrebna je kamera", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //beep if possible.
            }
            
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();

            timer1.Enabled = true;
            timer1.Start();

        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbQRKod.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void CbPaket_SelectedIndexChanged(object sender, EventArgs e)
        {
            var paket = (Paket)cbPaket.SelectedItem;

            if (paket != null)
                nudIznos.Value = paket.Cijena;

        }

        private void setScannerVisible(bool visible)
        {
            if (visible == true)
            {
                gbQRKodSkener.Visible = true;

                pbQRKod.Visible = true;
                pbQRKod.Location = new Point(18, 12);
                pbQRKod.Width = 488;
                pbQRKod.Height = 382;

                gbClanarina.Visible = false;

            }
            else
            {
                gbQRKodSkener.Visible = false;
                pbQRKod.Visible = false;
                gbClanarina.Visible = true;
            }

        }

    }
}
