﻿using System;
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
    public partial class frmIsplataRadnika : Form
    {
        APIService _apiService_Radnik;
        APIService _apiService_RadnikPlataHistorija;
        Validation _validation;

        public frmIsplataRadnika()
        {
            InitializeComponent();

            _validation = new Validation();
            _apiService_Radnik = new APIService("Radnik");
            _apiService_RadnikPlataHistorija = new APIService("RadnikPlataHistorija");

        }

        private async void FrmIsplataRadnika_Load(object sender, EventArgs e)
        {
            txtSatnica.ReadOnly = true;

            txtTotal.ReadOnly = true;

            TxtRadnihSati.Text = "0";

            var radnici = await _apiService_Radnik.Get<List<Model.Radnik>>(null);
            cbRadnik.DataSource = radnici;
            cbRadnik.ValueMember = "Id";
            cbRadnik.DisplayMember = "Display";
            cbRadnik.DropDownStyle = ComboBoxStyle.DropDownList;

            var radniciSearch = await _apiService_Radnik.Get<List<Model.Radnik>>(null);
            radniciSearch.Insert(0, new Model.Radnik()
            {

                Id = 0,
            });

            cbRadnikSearch.DataSource = radniciSearch;
            cbRadnikSearch.ValueMember = "Id";
            cbRadnikSearch.DisplayMember = "Display";
            cbRadnikSearch.DropDownStyle = ComboBoxStyle.DropDownList;

            var radnik = (Model.Radnik)cbRadnik.SelectedItem;

            txtSatnica.Text = Math.Round(radnik.Satnica, 2).ToString();


            var RadniciPlateHistorija = await _apiService_RadnikPlataHistorija.Get<List<Model.RadnikPlataHistorija>>(null);
            dgvIsplate.DataSource = RadniciPlateHistorija;

            foreach (DataGridViewRow row in dgvIsplate.Rows)
            {
                Model.RadnikPlataHistorija obj = (Model.RadnikPlataHistorija)row.DataBoundItem;

                row.Cells[4].Value = Math.Round((decimal)obj.Satnica, 2);
            }


        }

        private async void BtnEvidentirajUplatu_Click(object sender, EventArgs e)
        {
            btnEvidentirajUplatu.Enabled = false;

            if (this.ValidateChildren())
            {
                var radnik = (Model.Radnik)cbRadnik.SelectedItem;

                var radnikIsplataInsertRequest = new RadnikIsplataInsertRequest()
                {
                    DatumUplate = DateTime.Now,
                    RadnihSati = Convert.ToInt32(TxtRadnihSati.Text),
                    UplataZaGodinu = Convert.ToInt32(txtUplataZaGodinu.Text),
                    UplataZaMjesec = Convert.ToInt32(txtUplataZaMjesec.Text),
                    Satnica = radnik.Satnica,
                    RadnikId = radnik.Id
                };

                await _apiService_RadnikPlataHistorija.Insert<Model.RadnikPlataHistorija>(radnikIsplataInsertRequest);
                MessageBox.Show("Uspjesno ste evidentirali uplatu", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            btnEvidentirajUplatu.Enabled = true;
        }

        private void BtnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbRadnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSatnica.Text) && !string.IsNullOrEmpty(TxtRadnihSati.Text))
            {
                var radnik = (Model.Radnik)cbRadnik.SelectedItem;
                txtSatnica.Text = Math.Round(radnik.Satnica, 2).ToString();
                txtTotal.Text = Math.Round((Convert.ToInt32(TxtRadnihSati.Text) * radnik.Satnica), 2).ToString();
            }
        }



        private async void BtnTrazi_Click(object sender, EventArgs e)
        {
            var rphSearch = new RadnikIsplataSearchRequest();

            rphSearch.radnikId = (int?)cbRadnikSearch.SelectedValue;
            if (!string.IsNullOrWhiteSpace(txtUplataZaGodinuSearch.Text))
                rphSearch.UplataZaGodinu = Convert.ToInt32(txtUplataZaGodinuSearch.Text);
            if (!string.IsNullOrWhiteSpace(txtUplataZaMjesec.Text))
                rphSearch.UplataZaMjesec = Convert.ToInt32(txtUplataZaMjesec.Text);


            var RadniciPlateHistorija = await _apiService_RadnikPlataHistorija.Get<List<Model.RadnikPlataHistorija>>(rphSearch);
            dgvIsplate.DataSource = RadniciPlateHistorija;
        }

        private void TxtIzvor_Validating(object sender, CancelEventArgs e)
        {
            if (_validation.Required(sender, e, RadnikIsplataErrorProvider))
                if (_validation.IsNumberOnly(sender, e, RadnikIsplataErrorProvider))
                    _validation.MinMaxLength(sender, e, RadnikIsplataErrorProvider, 16, 16);
        }

        private void TxtUplataZaGodinu_Validating(object sender, CancelEventArgs e)
        {
            if (_validation.Required(sender, e, RadnikIsplataErrorProvider))
                _validation.MinMaxValue(sender, e, RadnikIsplataErrorProvider, 2000, 2100);
        }

        private void TxtUplataZaMjesec_Validating(object sender, CancelEventArgs e)
        {
            if (_validation.Required(sender, e, RadnikIsplataErrorProvider))
                _validation.MinMaxValue(sender, e, RadnikIsplataErrorProvider, 1, 12);
        }




        private void FrmIsplataRadnika_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void TxtRadnihSati_Validating_1(object sender, CancelEventArgs e)
        {
            if (_validation.Required(sender, e, RadnikIsplataErrorProvider))
                if (_validation.IsNumberOnly(sender, e, RadnikIsplataErrorProvider))
                    if (_validation.MinMaxValue(sender, e, RadnikIsplataErrorProvider, 0, 1000))
                    {
                        string str = TxtRadnihSati.Text;
                        foreach (char c in str)
                        {
                            if (c < '0' || c > '9')
                                return;
                        }


                        if (!string.IsNullOrEmpty(txtSatnica.Text) && !string.IsNullOrEmpty(TxtRadnihSati.Text))
                        {
                            var radnik = (Model.Radnik)cbRadnik.SelectedItem;
                            txtSatnica.Text = Math.Round(radnik.Satnica, 2).ToString();
                            txtTotal.Text = Math.Round((Convert.ToInt32(TxtRadnihSati.Text) * radnik.Satnica), 2).ToString();
                        }

                    }
        
        
        }
    }
}

