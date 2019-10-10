using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wellness.Mobile.AsyncHelper;
using Wellness.Mobile.Views;
using Xamarin.Forms;

namespace Mobile.ViewModels
{
    class PostavkeViewModel:BaseViewModel
    {



        APIService apiService_clan = new APIService("Clan");
        APIService apiService_osoba = new APIService("Osoba");

        Wellness.Model.Requests.ClanViewRequest _clan = null;

        private Mobile.Models.PostavkeModel _postavkeModel;
        public Mobile.Models.PostavkeModel postavkeModel
        {
            get { return this._postavkeModel; }
            set { this._postavkeModel = value; }
        }


       

        public PostavkeViewModel(Wellness.Model.Requests.ClanViewRequest clan = null)
        {
            _clan = clan;
            this._postavkeModel = new Models.PostavkeModel();

            SpasiCommand = new Command(async () => await Spasi());



            #region Init

            if (_clan != null)
            {
                var clanOsoba = AsyncHelpers.RunSync<Wellness.Model.Osoba>(() => apiService_osoba.GetById<Wellness.Model.Osoba>(clan.OsobaId));
                if (clanOsoba == null)
                    return;

                _postavkeModel.Id = clan.Id;
                _postavkeModel.Ime = clanOsoba.Ime;
                _postavkeModel.Prezime = clanOsoba.Prezime;
                _postavkeModel.DatumRodenja = clanOsoba.DatumRodenja;
                _postavkeModel.Jmbg = clanOsoba.Jmbg;
                _postavkeModel.BrojTelefona = clanOsoba.BrojTelefona;
                _postavkeModel.KorisnickoIme = clanOsoba.KorisnickoIme;
                _postavkeModel.Spol = clanOsoba.Spol;

            }
            #endregion Init

        }
        public PostavkeViewModel()
        {

        }


        public ICommand SpasiCommand { get; set; }
        public async Task Spasi()
        {
            var osobaInsertRequest = new Wellness.Model.Requests.OsobaInsertRequest()
            {
                Ime = _postavkeModel.Ime,
                Prezime = _postavkeModel.Prezime,
                DatumRodenja = _postavkeModel.DatumRodenja,
                Jmbg = _postavkeModel.Jmbg,
                BrojTelefona = _postavkeModel.BrojTelefona,
                KorisnickoIme = _postavkeModel.KorisnickoIme,
                Spol = _postavkeModel.Spol,
                Email=_postavkeModel.Email
            };
            var osoba =await apiService_osoba.Update<Wellness.Model.Osoba>(_clan.OsobaId, osobaInsertRequest);

            await PopupNavigation.Instance.PushAsync(new PopupView("Success", "Uspjesno ste azurirali profil"));

        }

    }
}
