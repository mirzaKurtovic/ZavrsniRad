using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wellness.Model.Requests;
using Wellness.WinUI.Menadzment;

namespace Wellness.WinUI.Clan
{
    public partial class frmClan : Form
    {

        APIService apiService_clanovi = new APIService("Clan");

        public frmClan()
        {
            InitializeComponent();
        }



        private async void frmClan_Load(object sender, EventArgs e)
        {
            await setDgvClanovi(null);

        }
        private async void btnTrazi_Click(object sender, EventArgs e)
        {
            var clanSearchRequest = new ClanSearchRequest()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                KorisnickoIme = txtKorisnickoIme.Text
            };

            await setDgvClanovi(clanSearchRequest);

        }
        private void dgvClanovi_DoubleClick(object sender, EventArgs e)
        {
            var clanId = (int)dgvClanovi.SelectedRows[0].Cells[4].Value;

            var frm = new frmRadniciDetalji(clanId, true);
            frm.Show();
        }

        private async Task setDgvClanovi(ClanSearchRequest request = null)
        {

            dgvClanovi.Rows.Clear();
            dgvClanovi.Refresh();

            var clanovi = await apiService_clanovi.Get<List<ClanViewRequest>>(request);
            
            foreach (var x in clanovi)
            {
                //DataGridViewRow row = (DataGridViewRow)dgvClanovi.Rows[0].Clone();
                //row.Cells[0].Value = x.Id;
                //row.Cells[1].Value = x.Ime;
                //row.Cells[2].Value = x.Prezime;
                //row.Cells[3].Value = x.Osoba.KorisnickoIme;
                dgvClanovi.Rows.Add(x.Id, x.Ime, x.Prezime, x.Osoba.KorisnickoIme, x.OsobaId);
            }

        }

    }
}
