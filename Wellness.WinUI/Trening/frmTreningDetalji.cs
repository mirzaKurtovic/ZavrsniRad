using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wellness.Model.Requests;

namespace Wellness.WinUI.Trening
{
   
    public partial class frmTreningDetalji : Form
    {

        private readonly APIService _apiService_TipTreninga = new APIService("TipTreninga");
        private readonly APIService _apiService_Trening = new APIService("Trening");
        private readonly APIService _apiService_TrenerSpecijalizacija = new APIService("TrenerSpecijalizacija");
        private readonly Validation _validation = new Validation();
        private readonly int? _id = null;
        private Wellness.Model.Trener _trener;
        public frmTreningDetalji(int? id, Wellness.Model.Trener trener)
        {
            _id = id;
            _trener = trener;
            InitializeComponent();
        }



        private async void BtnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                #region validateTime
                if (pocetakVeciOdKraja(dtpPocetak.Value, dtpKraj.Value))
                    return;



                var TreningSearch = new TreningSearchRequest()
                {
                    TipTreningaID = 0,
                    TrenerID = _trener.Id
                };
                var datumTreninga = dtpDatumTreninga.Value;
                var vrijemePocetak = dtpPocetak.Value;
                var vrijemeKraj = dtpKraj.Value;
                TreningSearch.DatumTreninga = new DateTime(datumTreninga.Year, datumTreninga.Month, datumTreninga.Day, 0, 0, 0, 0);
                TreningSearch.VrijemePocetak = new DateTime(datumTreninga.Year, datumTreninga.Month, datumTreninga.Day, vrijemePocetak.Hour, vrijemePocetak.Minute, 0, 0);
                TreningSearch.VrijemeKraj = new DateTime(datumTreninga.Year, datumTreninga.Month, datumTreninga.Day, vrijemeKraj.Hour, vrijemeKraj.Minute, 0, 0);
                var vecPostoji = await VecPostojiTrening(sender, TreningSearch);

                if (vecPostoji == true)
                    return;




                #endregion validateTime



                if (cbTipTreninga.Items.Count<=0)
                {
                    MessageBox.Show("Za dodavanje/uredivanje treninga potrebno je imati tipove treninga!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    return;
                }

                var request = new TreningInsertRequest()
                {
                    TipTreningaId = Convert.ToInt32(cbTipTreninga.SelectedValue),
                    DatumTreninga = new DateTime(dtpDatumTreninga.Value.Year, dtpDatumTreninga.Value.Month, dtpDatumTreninga.Value.Day,0,0,0,0),
                    VrijemePocetak = new DateTime(dtpDatumTreninga.Value.Year, dtpDatumTreninga.Value.Month, dtpDatumTreninga.Value.Day,dtpPocetak.Value.Hour,dtpPocetak.Value.Minute,0,0),
                    VrijemeKraj = new DateTime(dtpDatumTreninga.Value.Year, dtpDatumTreninga.Value.Month, dtpDatumTreninga.Value.Day, dtpKraj.Value.Hour, dtpKraj.Value.Minute, 0,0),
                    MaksimalnoPrisutnih = int.Parse(txtMaxPrisutnih.Text),
                    TrenerId = _trener.Id,
                };

                if (_id.HasValue)
                {
                    //request.Id = Convert.ToInt32(_id);
                    await _apiService_Trening.Update<Model.Trening>(_id, request);
                    this.Close();
                    MessageBox.Show("Uspješna promjena!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    await _apiService_Trening.Insert<Model.Trening>(request);
                    this.Close();
                    MessageBox.Show("Uspješna ste dodali novi trening!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
            }
        }
        private async void FrmTreningDetalji_Load(object sender, EventArgs e)
        {
            btnPogledajPrisutne.Hide();

            var tipTreningaDb = await _apiService_TipTreninga.Get<List<Model.TipTreninga>>(null);

            if (!_id.HasValue)
            {
                var trenerSpecijalizacijaList = await _apiService_TrenerSpecijalizacija.Get<List<Model.TrenerSpecijalizacija>>(new TrenerSpecijalizacijaSearchRequest { TrenerId = _trener.Id });
                List<Model.TipTreninga> tipTreninga = new List<Model.TipTreninga>();
                foreach (Wellness.Model.TrenerSpecijalizacija x in trenerSpecijalizacijaList)
                {
                    for (int i = 0; i < tipTreningaDb.Count; i++)
                    {
                        if (tipTreningaDb[i].Id == x.TipTreningaId)
                        {
                            tipTreninga.Add(tipTreningaDb[i]);
                            break;
                        }
                    }
                }
                cbTipTreninga.DataSource = tipTreninga;
            }
            else
            {
                cbTipTreninga.DataSource = tipTreningaDb;
                cbTipTreninga.Enabled = false;
            }
            cbTipTreninga.ValueMember = "Id";
            cbTipTreninga.DisplayMember = "TipTreninga1";
            cbTipTreninga.DropDownStyle = ComboBoxStyle.DropDownList;

            if (_id.HasValue)
            {
                var trening = await _apiService_Trening.GetById<Model.Trening>(_id);
                cbTipTreninga.SelectedValue = trening.TipTreningaId;
                dtpDatumTreninga.Value = trening.DatumTreninga;
                dtpPocetak.Value = trening.VrijemePocetak;
                dtpKraj.Value = trening.VrijemeKraj;
                txtMaxPrisutnih.Text = trening.MaksimalnoPrisutnih.ToString();
                btnPogledajPrisutne.Show();
            }
        }
        private void BtnPogledajPrisutne_Click(object sender, EventArgs e)
        {
            frmTreningPrisutni frm =new frmTreningPrisutni(_id);
            frm.Show();
        }
        


        


        private void DtpPocetak_Validating(object sender, CancelEventArgs e)
        {
            //var TreningSearch = new TreningSearchRequest()
            //{
            //    TipTreningaID = 0,
            //    TrenerID = _trener.Id
            //};
            //var datumTreninga = dtpDatumTreninga.Value;
            //var vrijemePocetak = dtpPocetak.Value;
            //var vrijemeKraj = dtpKraj.Value;
            //TreningSearch.DatumTreninga = new DateTime(datumTreninga.Year, datumTreninga.Month, datumTreninga.Day, 0, 0, 0, 0);
            //TreningSearch.VrijemePocetak = new DateTime(datumTreninga.Year, datumTreninga.Month, datumTreninga.Day, vrijemePocetak.Hour, vrijemePocetak.Minute, 0, 0);
            //TreningSearch.VrijemeKraj = new DateTime(datumTreninga.Year, datumTreninga.Month, datumTreninga.Day, vrijemeKraj.Hour, vrijemeKraj.Minute, 0, 0);
            //VecPostojiTrening(sender,TreningSearch, e);
            //DatumVeciOd(dtpPocetak.Value, dtpKraj.Value, e);

        }

        private void DtpKraj_Validating(object sender, CancelEventArgs e)
        {
        //....
        }

        private void TxtMaxPrisutnih_Validating(object sender, CancelEventArgs e)
        {
            if (_validation.Required(sender, e, epTreningDetalji))
                if (_validation.IsNumberOnly(sender, e, epTreningDetalji))
                    _validation.MinMaxValue(sender, e, epTreningDetalji, 1, 150);
        }

        private void BtnPonisti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTreningDetalji_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        //...................................................................................................

        bool pocetakVeciOdKraja(DateTime pocetak, DateTime kraj)
        {
            //pocetakVeciOdKraja

            DateTime pocetniSatiMinute = new DateTime(1, 1, 1, pocetak.Hour, pocetak.Minute, 0, 0);
            DateTime krajnjiSatiMinute = new DateTime(1, 1, 1, kraj.Hour, kraj.Minute, 0, 0);


            if (pocetniSatiMinute >= krajnjiSatiMinute)
            {
                MessageBox.Show("Pocetak treninga ne smije biti veci od kraja!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return true;
            }
            return false;

        }
        private async Task<bool> VecPostojiTrening(object sender, TreningSearchRequest TreningSearch)
        {
            var treningList = await _apiService_Trening.Get<List<Model.Trening>>(TreningSearch);
            if (_id != null)
            {
                //var tr =await _apiService_Trening.GetById<Model.Trening>(_id);
                treningList = treningList.Where(t => t.Id != _id).ToList();
            }

            if (treningList.Count != 0)
            {
                MessageBox.Show("Vec ste dodali trening u datom terminu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return true;
            }
            return false;
        }
    }
}
