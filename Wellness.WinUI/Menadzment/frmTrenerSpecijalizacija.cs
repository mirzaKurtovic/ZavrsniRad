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
    public partial class frmTrenerSpecijalizacija : Form
    {
        APIService _apiService_TrenerSpecijalizacija = new APIService("TrenerSpecijalizacija");
        APIService _apiService_Trener = new APIService("Trener");
        APIService _apiService_TipTreninga = new APIService("TipTreninga");
        bool isCbBussy = false;
        public frmTrenerSpecijalizacija(int? tipTreninga=null)
        {
            InitializeComponent();
        }

        private async void FrmTrenerSpecijalizacija_Load(object sender, EventArgs e)
        {
            var trenerList = await _apiService_Trener.Get<List<Model.Trener>>(null);
            cbTrener.DataSource = trenerList;
            cbTrener.DisplayMember = "Display";
            cbTrener.ValueMember = "Id";
            cbTrener.DropDownStyle = ComboBoxStyle.DropDownList;
            //-------------------------------------------------------------------------
            var tipTreningList = await _apiService_TipTreninga.Get<List<Model.TipTreninga>>(null);
            cbTipTreninga.DataSource = tipTreningList;
            cbTipTreninga.DisplayMember = "TipTreninga1";
            cbTipTreninga.ValueMember = "Id";
            cbTipTreninga.DropDownStyle = ComboBoxStyle.DropDownList;
            //-------------------------------------------------------------------------

            #region specijalizacija
            var trenerSpecijalizacijaList = await _apiService_TrenerSpecijalizacija.Get<List<Model.TrenerSpecijalizacija>>(null);
            dgvTrenerSpecijalizacija.DataSource = trenerSpecijalizacijaList;
            foreach (DataGridViewRow row in dgvTrenerSpecijalizacija.Rows)
            {
                Model.TrenerSpecijalizacija obj = (Model.TrenerSpecijalizacija)row.DataBoundItem;
                row.Cells[0].Value = obj.Id;
                row.Cells[1].Value = obj.Trener.Radnik.Osoba.Display;
                row.Cells[2].Value = obj.TipTreninga.TipTreninga1;
                var BtnCell = (DataGridViewButtonCell)row.Cells[3];
                BtnCell.Value = "Ukloni";
            }
            #endregion specijalizacija
        }

        private async void BtnSpasi_Click(object sender, EventArgs e)
        {
            if (isCbEmpty())
            {
                //messagebox fali
                return;
            }
            var trenerSpecijalizacijaInsertRequest = new Model.Requests.TrenerSpecijalizacijaInsertRequest()
            {
                TipTreningaId = (int)cbTipTreninga.SelectedValue,
                TrenerId = (int)cbTrener.SelectedValue
            };

            var result = await _apiService_TrenerSpecijalizacija.Insert<Model.TrenerSpecijalizacija>(trenerSpecijalizacijaInsertRequest);

            #region specijalizacija
            var trenerSpecijalizacijaList = await _apiService_TrenerSpecijalizacija.Get<List<Model.TrenerSpecijalizacija>>(null);
            dgvTrenerSpecijalizacija.DataSource = trenerSpecijalizacijaList;
            foreach (DataGridViewRow row in dgvTrenerSpecijalizacija.Rows)
            {
                Model.TrenerSpecijalizacija obj = (Model.TrenerSpecijalizacija)row.DataBoundItem;
                row.Cells[0].Value = obj.Id;
                row.Cells[1].Value = obj.Trener.Radnik.Osoba.Display;
                row.Cells[2].Value = obj.TipTreninga.TipTreninga1;
                var BtnCell = (DataGridViewButtonCell)row.Cells[3];
                BtnCell.Value = "Ukloni";
            }
            #endregion specijalizacija


            #region comboBoxUpdate
            await cbTipTreningaChanged();
            await cbTrenerChanged();
            #endregion comboBoxUpdate
        }

        private async void DgvTrenerSpecijalizacija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                var row = dgvTrenerSpecijalizacija.Rows[e.RowIndex];
                var trenerSpecijalizacijaId = row.Cells[0].Value;
                //dodati nekako da se pozove dati row..

                var result = await _apiService_TrenerSpecijalizacija.Delete<bool>(trenerSpecijalizacijaId);

                if(result==true)
                MessageBox.Show("Uspjesno ste uklonili specijalizaciju", "Success", MessageBoxButtons.OK,MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

                #region specijalizacija
                var trenerSpecijalizacijaList = await _apiService_TrenerSpecijalizacija.Get<List<Model.TrenerSpecijalizacija>>(null);
                dgvTrenerSpecijalizacija.DataSource = trenerSpecijalizacijaList;
                foreach (DataGridViewRow r in dgvTrenerSpecijalizacija.Rows)
                {
                    Model.TrenerSpecijalizacija obj = (Model.TrenerSpecijalizacija)r.DataBoundItem;
                    r.Cells[0].Value = obj.Id;
                    r.Cells[1].Value = obj.Trener.Radnik.Osoba.Display;
                    r.Cells[2].Value = obj.TipTreninga.TipTreninga1;
                    var BtnCell = (DataGridViewButtonCell)r.Cells[3];
                    BtnCell.Value = "Ukloni";
                }
                #endregion specijalizacija

                #region comboBoxUpdate

                await cbTrenerChanged();
                await cbTipTreningaChanged();
                #endregion comboBoxUpdate

            }
        }

        private  async void CbTrener_SelectedIndexChanged(object sender, EventArgs e)
        {
             await cbTrenerChanged();
        }
        private async Task cbTrenerChanged()
        {
            if (isCbBussy == false)
            {
                if (isCbTrenerEmpty())
                    return;
                isCbBussy = true;
                var tipTreningList = await _apiService_TipTreninga.Get<List<Model.TipTreninga>>(null);
                var trenerSpecijalizacijaList = await _apiService_TrenerSpecijalizacija.Get<List<Model.TrenerSpecijalizacija>>(new Model.Requests.TrenerSpecijalizacijaSearchRequest()
                {

                    TrenerId = (int)cbTrener.SelectedValue
                });

                List<Model.TipTreninga> temp = new List<Model.TipTreninga>();
                bool taken = false;
                for (int i = 0; i < tipTreningList.Count; i++)
                {
                    taken = false;
                    foreach (Model.TrenerSpecijalizacija y in trenerSpecijalizacijaList)
                    {
                        if (tipTreningList[i].Id == y.TipTreningaId)
                        {
                            taken = true;
                            break;
                        }
                    }
                    if (taken == false)
                        temp.Add(tipTreningList[i]);
                }
                cbTipTreninga.DataSource = temp;
                isCbBussy = false;
            }
        }

        private async void CbTipTreninga_SelectedIndexChanged(object sender, EventArgs e)
        {
            await cbTipTreningaChanged();
        }
        private async Task cbTipTreningaChanged()
        {
            if (isCbBussy == false)
            {
                if (isCbTipTreningaEmpty())
                    return;
                isCbBussy = true;
                
                var trenerList = await _apiService_Trener.Get<List<Model.Trener>>(null);
                var trenerSpecijalizacijaList = await _apiService_TrenerSpecijalizacija.Get<List<Model.TrenerSpecijalizacija>>(new Model.Requests.TrenerSpecijalizacijaSearchRequest()
                {

                    TipTreningaId = (int)cbTipTreninga.SelectedValue
                });

                List<Model.Trener> temp = new List<Model.Trener>();
                bool taken = false;
                for (int i = 0; i < trenerList.Count; i++)
                {
                    taken = false;
                    foreach (Model.TrenerSpecijalizacija y in trenerSpecijalizacijaList)
                    {
                        if (trenerList[i].Id == y.TipTreningaId)
                        {
                            taken = true;
                            break;
                        }
                    }
                    if (taken == false)
                        temp.Add(trenerList[i]);
                }
                cbTrener.DataSource = temp;

                isCbBussy = false;
            }
        }

        bool isCbEmpty()
        {
            if (cbTipTreninga.Items.Count <= 0 || cbTrener.Items.Count <= 0)
                return true;
            return false;
        }
        bool isCbTrenerEmpty()
        {
            if (cbTrener.Items.Count <= 0)
                return true;
            return false;
        }
        bool isCbTipTreningaEmpty()
        {
            if (cbTipTreninga.Items.Count <= 0)
                return true;
            return false;
        }
    }
}
