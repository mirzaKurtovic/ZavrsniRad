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

namespace Wellness.WinUI.Menadzment
{
    public partial class frmPaketDetalji : Form
    {

        APIService _apiService_PristupDanima = new APIService("PristupDanima");
        byte[] Img = null;
        public frmPaketDetalji()
        {
            InitializeComponent();
        }



        private async void FrmPaketDetalji_Load(object sender, EventArgs e)
        {

            txtSlika.ReadOnly = true;

            List<Model.PristupDanima> PristupDanimaList = await _apiService_PristupDanima.Get<List<Model.PristupDanima>>(null);
            for (int i = 0; i < PristupDanimaList.Count; i++)
            {
                clbPristupniDani.Items.Add(PristupDanimaList[i]);
                clbPristupniDani.DisplayMember = "DanUSedmici";
                //DataRowView row = (DataRowView)((ListBox)clbPristupniDani).Items[i];
                //bool isChecked = Convert.ToBoolean(row["checked"]);
                //clbPristupniDani.SetItemChecked(i, isChecked);
            }


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

        private void BtnDodajPaket_Click(object sender, EventArgs e)
        {
            var PaketInsertRequest = new Wellness.Model.Requests.PaketInsertRequest
            {
                Naziv = txtNaziv.Text,
                Cijena = Convert.ToDecimal(txtCijena.Text),
                Opis = txtOpis.Text,
                PristupGrupnimTreninzima = cbPristupGrupnimTreninzima.Checked,
                NeogranicenPristup = cbNeogranicenPristup.Checked,
                Slika = Img
                
            };

            if(PaketInsertRequest.NeogranicenPristup==false)
            {
                DateTime Od =new DateTime(2000,1,1, dtpDatumOd.Value.Hour,dtpDatumOd.Value.Minute,1,1);
                DateTime Do = new DateTime(2000, 1, 1, dtpDatumDo.Value.Hour, dtpDatumDo.Value.Minute, 1, 1);

                PaketInsertRequest.VrijemePristupaOd = Od;
                PaketInsertRequest.VrijemePristupaDo = Do;
            }



            foreach(Wellness.Model.PristupDanima x in clbPristupniDani.CheckedItems)
            {
                //dodati u bp...
            }
        }

        private void BtnDodajSliku_Click(object sender, EventArgs e)
        {
            // open file dialog   
            var open = openFileDialog1;
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                
                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);
                pbSlika.Image = image;
            }
        }
    }
}
