using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wellness.Model.Requests;

namespace Wellness.WinUI.Menadzment
{
    public partial class frmPaketi : Form
    {

        APIService apiService_Paket = new APIService("Paket");

        public frmPaketi()
        {
            InitializeComponent();
        }

        private async void FrmPaketi_Load(object sender, EventArgs e)
        {
            var paketi =await  apiService_Paket.Get<List<Model.Paket>>(null);
            dgvPaketi.DataSource = paketi;
            foreach (DataGridViewRow row in dgvPaketi.Rows)
            {
                Model.Paket obj = (Model.Paket)row.DataBoundItem;

                row.Cells[3].Value = Math.Round((decimal)obj.Cijena, 2);
                if(obj.VrijemePristupaOd.HasValue)
                row.Cells[8].Value = obj.VrijemePristupaOd.Value.ToShortTimeString();
                if (obj.VrijemePristupaDo.HasValue)
                    row.Cells[10].Value = obj.VrijemePristupaDo.Value.ToShortTimeString();
            }
            //-----------------------------------------------------------------------------
            List<string> Sortiranje = new List<string>();
            Sortiranje.Add("Cijena rast.");
            Sortiranje.Add("Cijena opad.");
            cbSortiranje.DataSource = Sortiranje;
            cbSortiranje.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private async void BtnTrazi_Click(object sender, EventArgs e)
        {
            btnTrazi.Enabled = false;

            var naziv = "";
            decimal? cijenaVeceOd=null;
            decimal? cijenaManjeOd=null;
            string sortirajPo = (string)cbSortiranje.SelectedValue;

            if (!string.IsNullOrEmpty(txtNazivPaketa.Text))
            {
                naziv = txtNazivPaketa.Text;
            }
                if (!string.IsNullOrEmpty(txtCijenaVeceOd.Text))
            {
                 cijenaVeceOd = Convert.ToDecimal(txtCijenaVeceOd.Text);
            }
            if (!string.IsNullOrEmpty(txtCijenaManjeOd.Text))
            {
                 cijenaManjeOd = Convert.ToDecimal(txtCijenaManjeOd.Text);
            }
            

            var paketSearchRequest = new Model.Requests.PaketSearchRequest()
            {
                NazivPaketa=naziv,
                CijenaVecaOd=cijenaVeceOd,
                CijenaManjaOd=cijenaManjeOd
            };

            var paketi = await apiService_Paket.Get<List<Model.Paket>>(paketSearchRequest);

            if(sortirajPo=="Cijena rast.")
            paketi = paketi.OrderBy(c => c.Cijena).ToList();
            if (sortirajPo == "Cijena opad.")
                paketi = paketi.OrderByDescending(c => c.Cijena).ToList();

            dgvPaketi.DataSource = paketi;
            foreach (DataGridViewRow row in dgvPaketi.Rows)
            {
                Model.Paket obj = (Model.Paket)row.DataBoundItem;

                row.Cells[3].Value = Math.Round((decimal)obj.Cijena, 2);
                if (obj.VrijemePristupaOd.HasValue)
                    row.Cells[8].Value = obj.VrijemePristupaOd.Value.ToShortTimeString();
                if (obj.VrijemePristupaDo.HasValue)
                    row.Cells[10].Value = obj.VrijemePristupaDo.Value.ToShortTimeString();
            }

            btnTrazi.Enabled = true;
        }

        private void DgvPaketi_DoubleClick(object sender, EventArgs e)
        {
            var paketId = (int)dgvPaketi.SelectedRows[0].Cells[0].Value;



            var frm = new frmPaketDetalji(paketId);
            frm.Show();


        }
    }
}
