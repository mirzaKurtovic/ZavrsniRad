using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wellness.Mobile.AsyncHelper;
using Xamarin.Forms;

namespace Mobile.ViewModels
{




    class ClanarinaViewModel:BaseViewModel
    {

        private readonly APIService _apiService;
        private readonly Wellness.Model.Requests.ClanViewRequest _clan;

        public ICommand InitCommand { get; set; }

        public ObservableCollection<Mobile.Models.ClanarinaModel> clanarine { get; set; } = new ObservableCollection<Mobile.Models.ClanarinaModel>();
        public ObservableCollection<int> UplataZaGodinu { get; set; } = new ObservableCollection<int>();
        public ObservableCollection<int> UplataZaMjesec { get; set; } = new ObservableCollection<int>();
        public ObservableCollection<string> SortirajPo { get; set; } = new ObservableCollection<string>();



        #region filter
        private int? SelectedUplataZaMjesec { get; set; }
        public int? _SelectedUplataZaMjesec
        {
            get { return SelectedUplataZaMjesec; }
            set
            {
                SelectedUplataZaMjesec = value;
                if (value != null)
                    InitCommand.Execute(null);
            }
        }
        private int? SelectedUplataZaGodinu { get; set; }
        public int? _SelectedUplataZaGodinu
        {
            get { return SelectedUplataZaGodinu; }
            set
            {
                SelectedUplataZaGodinu = value;
                if (value != null)
                    InitCommand.Execute(null);
            }
        }
        #endregion filter


        public ClanarinaViewModel(Wellness.Model.Requests.ClanViewRequest clan)
        {
            _apiService = new APIService("Clanarina");
            _clan = clan;

            #region filters
            //UplataZaGodinu.Add(0);
            //UplataZaMjesec.Add(0);


            List<int> upG = new List<int>();
            List<int> upM = new List<int>();
            var clanarinaFilter = AsyncHelpers.RunSync<List<Wellness.Model.Clanarina>>(() => _apiService.Get<List<Wellness.Model.Clanarina>>(null));

            clanarinaFilter = clanarinaFilter.OrderBy(c => c.UplataZaGodinu).ToList();
            upG = clanarinaFilter.Select(c => c.UplataZaGodinu).Distinct().ToList();

            clanarinaFilter = clanarinaFilter.OrderBy(c => c.UplataZaMjesec).ToList();
            upM = clanarinaFilter.Select(c => c.UplataZaMjesec).Distinct().ToList();


            foreach (int x in upG)
            {
                UplataZaGodinu.Add(x);
            }

            foreach (int x in upM)
            {
                UplataZaMjesec.Add(x);
            }
            #endregion filters



            InitCommand = new Command(async () => await Init());


            if (UplataZaGodinu[0] != 0)
                _SelectedUplataZaGodinu = UplataZaGodinu[0];
            if (UplataZaMjesec[0] != 0)
                _SelectedUplataZaMjesec = UplataZaMjesec[0];

        }

        public ClanarinaViewModel()
        {

        }








        public async Task Init()
        {



            var clanarinaSearchRequest = new Wellness.Model.Requests.ClanarinaSearchRequest()
            {
                ClanID = _clan.Id
            };

            var clanarinaList = await _apiService.Get<IEnumerable<Wellness.Model.Clanarina>>(clanarinaSearchRequest);





            clanarine.Clear();
            foreach (Wellness.Model.Clanarina x in clanarinaList)
            {
                if (x.UplataZaMjesec == _SelectedUplataZaMjesec && x.UplataZaGodinu == _SelectedUplataZaGodinu)
                {
                    var clanarina = new Mobile.Models.ClanarinaModel()
                    {
                        DatumUplate = x.DatumUplate,
                        IznosUplate = Math.Round(x.IznosUplate, 2),
                        Paket = x.Paket.Naziv,
                        UplataZaMjesec = x.UplataZaMjesec,
                        UplataZaGodinu = x.UplataZaGodinu
                    };


                    clanarine.Add(clanarina);
                }
            }
        }




    }
}
