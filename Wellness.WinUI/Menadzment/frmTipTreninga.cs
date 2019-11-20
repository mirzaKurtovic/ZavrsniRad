using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wellness.WinUI.Menadzment
{
    public partial class frmTipTreningaDetalji : Form
    {

        private readonly APIService _apiService_TipTreninga = new APIService("TipTreninga");

        public frmTipTreningaDetalji()
        {
            InitializeComponent();
        }

        private async void FrmTipTreningaDetalji_Load(object sender, EventArgs e)
        {
            var tipoviTreninga =await _apiService_TipTreninga.Get<List<Model.TipTreninga>>(null);
            dgvTipTreninga.DataSource = tipoviTreninga;
            foreach (DataGridViewRow row in dgvTipTreninga.Rows)
            {
                Model.TipTreninga obj = (Model.TipTreninga)row.DataBoundItem;
                var BtnCell = (DataGridViewButtonCell)row.Cells[4];
                BtnCell.Value = "Dodjeli treneru";
            }
        }

        private async void BtnTrazi_Click(object sender, EventArgs e)
        {
            btnTrazi.Enabled = false;
            var naziv = txtNaziv.Text;
            var tipTreningaSearchRequest = new Model.Requests.TipTreningaSearchRequest() {
                TipTreninga1 = naziv
            };
            var tipoviTreninga = await _apiService_TipTreninga.Get<List<Model.TipTreninga>>(tipTreningaSearchRequest);
            dgvTipTreninga.DataSource = tipoviTreninga;
            foreach (DataGridViewRow row in dgvTipTreninga.Rows)
            {
                Model.TipTreninga obj = (Model.TipTreninga)row.DataBoundItem;
                var BtnCell = (DataGridViewButtonCell)row.Cells[4];
                BtnCell.Value = "Dodjeli treneru";
            }
            btnTrazi.Enabled = true;
        }

        //https://stackoverflow.com/questions/3577297/how-to-handle-click-event-in-button-column-in-datagridview
        private void DgvTipTreninga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

                var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //dodati nekako da se pozove dati row..
                //var tipTreningaId = senderGrid.Columns[0];
                var frm = new frmTrenerSpecijalizacija();
                frm.Show();
            }

            
        }

        private void dgvTipTreninga_DoubleClick(object sender, EventArgs e)
        {
            Model.TipTreninga obj = (Model.TipTreninga)dgvTipTreninga.SelectedRows[0].DataBoundItem;
            var frm = new frmTipTreninga(obj);
            frm.Show();
        }
    }
}
