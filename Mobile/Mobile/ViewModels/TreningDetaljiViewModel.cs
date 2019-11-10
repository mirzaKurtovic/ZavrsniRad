using System;
using System.Collections.Generic;
using System.Text;
using Wellness.Mobile.AsyncHelper;
using Wellness.Model.Requests;

namespace Mobile.ViewModels
{
    class TreningDetaljiViewModel : BaseViewModel
    {

        public Wellness.Model.Trening _trening { get; set; }
        public Wellness.Model.Requests.ClanViewRequest _clan { get; set; }
        public Mobile.Models.TreningDetaljiModel treningDetaljiModel { get; set; }

        public Mobile.Models.TreningModel TreningMod { get; set; }

        APIService apiService_ClanPrisustvo = new APIService("ClanPrisustvo");
        public TreningDetaljiViewModel(Wellness.Model.Trening trening, Wellness.Model.Requests.ClanViewRequest clan)
        {
            treningDetaljiModel = new Mobile.Models.TreningDetaljiModel();
            _trening = trening;
            _clan = clan;


            var trenutnoPrisutnih = AsyncHelpers.RunSync<List<Wellness.Model.ClanPrisustvo>>(() => apiService_ClanPrisustvo.Get<List<Wellness.Model.ClanPrisustvo>>(new ClanPrisustvoSearchRequest() { TreningId = trening.Id }));
            var treningModel = new Mobile.Models.TreningModel()
            {

                Id = trening.Id,
                DatumTreninga = trening.DatumTreninga.ToString("dd.MM.yyyy"),
                pocetak = trening.VrijemePocetak,
                kraj = trening.VrijemeKraj,
                MaxPrisutnih = trening.MaksimalnoPrisutnih,
                Trener = trening.Trener.Radnik.Osoba.Ime + " " + trening.Trener.Radnik.Osoba.Prezime,
                TipTreninga = trening.TipTreninga.TipTreninga1,
                ClanId = clan.Id,
                TrenutnoPrisutnih = trenutnoPrisutnih.Count,
                Image = trening.TipTreninga.Image
            };

            treningDetaljiModel.TreningModel = treningModel;
            TreningMod = treningModel;



            var prisustvo = AsyncHelpers.RunSync<List<Wellness.Model.ClanPrisustvo>>(() => apiService_ClanPrisustvo.Get<List<Wellness.Model.ClanPrisustvo>>(new ClanPrisustvoSearchRequest() { TreningId = trening.Id, ClanId = clan.Id }));


            if (prisustvo.Count > 0)
            {
                treningModel.ClanPrisustvovaoTreningu = prisustvo[0].Prisustvovao;
                treningModel._Prisustvuje = true;
                treningModel.PrisustvoId = prisustvo[0].Id;
                treningModel.Odrzan = _trening.Odrzan;
                if (prisustvo[0].Ocjena != null)
                {
                    treningModel._Ocjena = (int)prisustvo[0].Ocjena;
                    treningModel.Ocjenjen = true;
                }
                else
                {
                    treningModel._Ocjena = 0;
                    treningModel.Ocjenjen = false;
                }
            }
            else
            {
                if (prisustvo.Count == 0)
                {
                    treningModel.ClanPrisustvovaoTreningu = false;
                    treningModel._Prisustvuje = false;
                    treningModel.Ocjenjen = false;
                    treningModel.PrisustvoId = 0;
                    treningModel._Ocjena = 0;
                }
            }

            List<Mobile.Models.PrisutniModel> prisutni = new List<Mobile.Models.PrisutniModel>();
            foreach (Wellness.Model.ClanPrisustvo x in trenutnoPrisutnih)
            {
                Mobile.Models.PrisutniModel p = new Mobile.Models.PrisutniModel()
                {
                    DatumPrijave = ((DateTime)x.DatumPrijave).ToString("dd.MM.yyyy"),
                    Ime = x.Clan.Osoba.Ime,
                    Prezime = x.Clan.Osoba.Prezime,
                    Ocjena = x.Ocjena,
                    Prisustvovao = x.Prisustvovao,
                    Id = x.Id,
                };

                prisutni.Add(p);
            }
            treningDetaljiModel.PrisutniModel = prisutni;





        }

        public TreningDetaljiViewModel()
        {

        }
    
    }
}
