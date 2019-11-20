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
    public partial class frmPromjeniSifru : Form
    {
        public int _id { get; set; }
        APIService apiService_Osoba = new APIService("Osoba");
        APIService apiService_Sifra= new APIService("Sifra");
        Model.Osoba osoba = null;
        public frmPromjeniSifru(int id)
        {
            InitializeComponent();

            this._id = id;
        }

        private async void frmPromjeniSifru_Load(object sender, EventArgs e)
        {
            osoba = await apiService_Osoba.GetById<Model.Osoba>(_id);

            if (osoba != null)
            {
                lblKorisnickoIme.Text = osoba.KorisnickoIme;
            }
            else
            {
                MessageBox.Show("Korisnik nije pronadjen", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }



        private async void btnSpasi_Click(object sender, EventArgs e)
        {
            if (txtSifra.Text == txtSifraPotvrda.Text)
            {
                var isChanged = await apiService_Sifra.Update<bool>(osoba.Id, txtSifra.Text);
                if(isChanged)
                MessageBox.Show("Sifra uspjesno promjenjena", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                MessageBox.Show("Greska prilikom promjene sifre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                MessageBox.Show("Sifra i sifra potvrda se ne poklapaju", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
