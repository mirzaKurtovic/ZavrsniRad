using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wellness.Model.Requests;

namespace Wellness.WinUI.Menadzment
{
    public partial class frmPaketDetalji : Form
    {

        APIService _apiService_PristupDanima = new APIService("PristupDanima");
        APIService _apiService_Paket = new APIService("Paket");
        APIService _apiService_PaketPristupniDani = new APIService("PaketPristupniDani");

        public Wellness.Model.Paket p = null;

        Validation _validation = new Validation();

        byte[] Img = null;
        int? paketId = null;
        public frmPaketDetalji(int? paketId=null)
        {
            InitializeComponent();

            this.paketId = paketId;
        }



        private async void FrmPaketDetalji_Load(object sender, EventArgs e)
        {
            #region init
            txtSlika.ReadOnly = true;
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;

            List<Model.PristupDanima> PristupDanimaList = await _apiService_PristupDanima.Get<List<Model.PristupDanima>>(null);
            for (int i = 0; i < PristupDanimaList.Count; i++)
            {
                clbPristupniDani.Items.Add(PristupDanimaList[i]);
                clbPristupniDani.DisplayMember = "DanUSedmici";
                //DataRowView row = (DataRowView)((ListBox)clbPristupniDani).Items[i];
                //bool isChecked = Convert.ToBoolean(row["checked"]);
                //clbPristupniDani.SetItemChecked(i, isChecked);
            }
            #endregion init

            #region alter
            if (paketId != null)
            {



                var paketList = await _apiService_Paket.Get<List<Model.Paket>>(new PaketSearchRequest()
                {

                    Id = (int)paketId
                });
                var paket = paketList[0];
                p = paket;
                if (paket != null)
                {
                    if (!string.IsNullOrEmpty(paket.Naziv))
                    {
                        txtNaziv.Text = paket.Naziv;
                    }

                    //txtCijena.Text = Math.Round(Convert.ToDouble(paket.Cijena, new CultureInfo("en-US")),2).ToString();
                    //--------------------
                    nudCijena.Value = paket.Cijena;
                    //------------------
                    if (!string.IsNullOrEmpty(paket.Opis))
                    {
                        txtOpis.Text = paket.Opis;
                    }
                    cbNeogranicenPristup.Checked = (bool)paket.NeogranicenPristup;
                    cbPristupGrupnimTreninzima.Checked = (bool)paket.PristupGrupnimTreninzima;
                    if (paket.VrijemePristupaOd.HasValue)
                    {
                        dtpDatumOd.Value = (DateTime)paket.VrijemePristupaOd;
                    }
                    if (paket.VrijemePristupaDo.HasValue)
                    {
                        dtpDatumDo.Value = (DateTime)paket.VrijemePristupaDo;
                    }
                    if (paket.Slika != null && paket.Slika.Count()>0)
                    {
                        pbSlika.Image = ByteToImage(paket.Slika); // byteArr holds byte array value;
                    }
                    var paketPristupniDani = await _apiService_PaketPristupniDani.Get<List<Model.PaketPristupniDani>>(new PaketPristupniDaniSearchRequest()
                    {

                        PaketId = (int)paketId
                    });




                    List<int> indeksi = new List<int>();
                    int brojac = -1;
                    foreach (Model.PristupDanima x in clbPristupniDani.Items)
                    {
                        brojac++;




                        for (int i = 0; i < paketPristupniDani.Count; i++)
                        {
                            if (x.DanUSedmici == paketPristupniDani[i].PristupniDani.DanUSedmici)
                            {
                                indeksi.Add(brojac);
                                break;
                            }
                        }
                    }

                    for (int i = 0; i < indeksi.Count; i++)
                    {
                        clbPristupniDani.SetItemChecked(indeksi[i], true);
                    }


                }
            }
            #endregion alter

        }

        private void CbNeogranicenPristup_CheckedChanged(object sender, EventArgs e)
        {
            if(cbNeogranicenPristup.Checked==true)
            {
                dtpDatumOd.Enabled = false;
                dtpDatumDo.Enabled = false;
            }
            else
            {
                dtpDatumOd.Enabled = true;
                dtpDatumDo.Enabled = true;
            }
        }

        private async void BtnDodajPaket_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var PaketInsertRequest = new Wellness.Model.Requests.PaketInsertRequest
                {
                    Naziv = txtNaziv.Text,
                    Cijena = nudCijena.Value,
                    Opis = txtOpis.Text,
                    PristupGrupnimTreninzima = cbPristupGrupnimTreninzima.Checked,
                    NeogranicenPristup = cbNeogranicenPristup.Checked,
                };
                if (Img != null)
                {
                    PaketInsertRequest.Slika = Img;
                }
                else
                {
                    if (p != null)
                    {
                        PaketInsertRequest.Slika = p.Slika;
                    }
                }

                if (PaketInsertRequest.NeogranicenPristup == false)
                {
                    DateTime Od = new DateTime(2000, 1, 1, dtpDatumOd.Value.Hour, dtpDatumOd.Value.Minute, 1, 1);
                    DateTime Do = new DateTime(2000, 1, 1, dtpDatumDo.Value.Hour, dtpDatumDo.Value.Minute, 1, 1);

                    PaketInsertRequest.VrijemePristupaOd = Od;
                    PaketInsertRequest.VrijemePristupaDo = Do;
                }

                if (paketId == null)
                {
                    var paketDB = await _apiService_Paket.Insert<Model.Paket>(PaketInsertRequest);


                    foreach (Wellness.Model.PristupDanima x in clbPristupniDani.CheckedItems)
                    {
                        var paketPristupniDaniInsertRequest = new Model.Requests.PaketPristupniDaniInsertRequest()
                        {
                            PaketId = paketDB.Id,
                            PristupniDaniId = x.Id
                        };

                        await _apiService_PaketPristupniDani.Insert<Model.PaketPristupniDani>(paketPristupniDaniInsertRequest);
                    }

                    //doradit
                    MessageBox.Show("Uspjesno ste dodali novi paket", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    var paketDB = await _apiService_Paket.Update<Model.Paket>(paketId, PaketInsertRequest);
                    var paketPristupniDani = await _apiService_PaketPristupniDani.Get<List<Model.PaketPristupniDani>>(new PaketPristupniDaniSearchRequest()
                    {

                        PaketId = (int)paketId
                    });

                    foreach (Model.PaketPristupniDani x in paketPristupniDani)
                    {
                        await _apiService_PaketPristupniDani.Delete<bool>(x.Id);
                    }
                    foreach (Wellness.Model.PristupDanima x in clbPristupniDani.CheckedItems)
                    {
                        var paketPristupniDaniInsertRequest = new Model.Requests.PaketPristupniDaniInsertRequest()
                        {
                            PaketId = paketDB.Id,
                            PristupniDaniId = x.Id
                        };
                        await _apiService_PaketPristupniDani.Insert<Model.PaketPristupniDani>(paketPristupniDaniInsertRequest);

                    }
                    MessageBox.Show("Uspjesno ste azurirali paket", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                Close();
            }
        }

        private void BtnDodajSliku_Click(object sender, EventArgs e)
        {
            // open file dialog   
            var open = openFileDialog1;
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);
                Img = file;

                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);
                pbSlika.Image = image;
            }
        }
        //https://stackoverflow.com/questions/9576868/how-to-put-image-in-a-picture-box-from-a-byte-in-c-sharp
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TxtSlika_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (_validation.Required(sender, e, PaketErrorProvider))
                if (_validation.IsLetterOnly(sender, e, PaketErrorProvider))
                    _validation.MinMaxLength(sender, e, PaketErrorProvider, 5, 64);
        }

        private void TxtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (_validation.Required(sender, e, PaketErrorProvider))
                _validation.IsDecimalNumber(sender, e, PaketErrorProvider);
        }

        private void TxtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (_validation.Required(sender, e, PaketErrorProvider))
                    _validation.MinMaxLength(sender, e, PaketErrorProvider, 5, 2048);
        }

        private void NudCijena_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtSlika_Validating(object sender, CancelEventArgs e)
        {
            if (p == null)
            {
                _validation.Required(sender, e, PaketErrorProvider);
            }
        }
    }
}
