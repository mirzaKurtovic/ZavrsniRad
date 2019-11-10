using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wellness.Model.Requests;

namespace Wellness.WinUI.Menadzment
{
    public partial class frmTipTreninga : Form
    {
        TipTreningaInsertRequest request = new TipTreningaInsertRequest();
        APIService _apiService_tipTreninga = new APIService("TipTreninga");
        private readonly Validation _validation = new Validation();
        Wellness.Model.TipTreninga _tipTreninga = null;

        byte[] img = null;

        public frmTipTreninga(Wellness.Model.TipTreninga tipTreninga)
        {
            InitializeComponent();

            _tipTreninga = tipTreninga;

        }

        private void TipTreninga_Load(object sender, EventArgs e)
        {
            txtSlika.ReadOnly = true;

            if (_tipTreninga !=null)
            {
                txtNaziv.Text = _tipTreninga.TipTreninga1;
                txtOpis.Text = _tipTreninga.Opis;
                if (_tipTreninga.Image != null)
                    if(_tipTreninga.Image.Count()>0)
                    pbSlika.Image = pbSlika.Image = ByteToImage(_tipTreninga.Image);
                
            }
        }

        private void BtnSlikaNova_Click(object sender, EventArgs e)
        {
            // open file dialog   
            var open = openFileDialog1;
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                img = file;
                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);
                pbSlika.Image = image;
            }
        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
                if (this.ValidateChildren())
                {
                request.TipTreninga1 = txtNaziv.Text;
                request.Opis = txtOpis.Text;
                if (img != null)
                {
                    request.Image = img;
                }
                else
                {
                    if (_tipTreninga != null)
                    {
                        request.Image = _tipTreninga.Image;
                    }
                    else
                        request.Image = null;
                }






                if (_tipTreninga != null)
                {

                    var tt = await _apiService_tipTreninga.Update<Wellness.Model.TipTreninga>(_tipTreninga.Id, request);

                    MessageBox.Show("Uspjesno ste azurirali tip treninga", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    var tt = await _apiService_tipTreninga.Insert<Wellness.Model.TipTreninga>(request);

                    MessageBox.Show("Uspjesno ste dodali novi tip treninga", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }

                Close();
            }

        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (_validation.Required(sender, e, tipTreningaErrorProvider))
                if (_validation.IsLetterOnly(sender, e, tipTreningaErrorProvider))
                    _validation.MinMaxLength(sender, e, tipTreningaErrorProvider, 1, 64);
        }

        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (_validation.Required(sender, e, tipTreningaErrorProvider))
                //if (_validation.IsLetterOnly(sender, e, tipTreningaErrorProvider))
                    _validation.MinMaxLength(sender, e, tipTreningaErrorProvider, 5, 2048);
        }

        private void txtSlika_Validating(object sender, CancelEventArgs e)
        {
            if (_tipTreninga == null)
            {
                _validation.Required(sender, e, tipTreningaErrorProvider);
            }
        }

        private void frmTipTreninga_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
