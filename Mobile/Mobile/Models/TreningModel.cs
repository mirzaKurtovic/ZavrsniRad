using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wellness.Mobile.AsyncHelper;
using Mobile.Views;
using Xamarin.Forms;
using Wellness.Model.Requests;
using Wellness.Mobile.Views;
using System.ComponentModel;

namespace Mobile.Models
{
    public class TreningModel
    {
        private APIService _apiService_ClanPrisustvo = new APIService("ClanPrisustvo");
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<System.ComponentModel.DataErrorsChangedEventArgs> ErrorsChanged;


        public int Id { get; set; }
        public string DatumTreninga
        {
            get;
            set;
        }
        public DateTime DatumT { get; set; }
        public DateTime pocetak { get; set; }
        public DateTime kraj { get; set; }
        public int MaxPrisutnih { get; set; }
        public int TrenutnoPrisutnih { get; set; }
        public string Trener { get; set; }
        public string TipTreninga { get; set; }
        public int ClanId { get; set; }
        public bool? ClanPrisustvovaoTreningu { get; set; }
        public bool? Odrzan { get; set; }
        public bool Ocjenjen { get; set; }
        public byte[] Image { get; set; }

        public int _Ocjena { get; set; }
        public int Ocjena
        {
            get { return _Ocjena; }
            set
            {
                _Ocjena = value;
            }
        }
        public int PrisustvoId { get; set; }
        public bool _Prisustvuje { get; set; }
        public bool Prisustvuje
        {
            get { return _Prisustvuje; }
            set
            {

                if (_Prisustvuje != value)
                {
                    if (value == false && PrisustvoId != 0)
                    {
                        var result = _apiService_ClanPrisustvo.Delete<bool>(PrisustvoId);
                        PrisustvoId = 0;
                        _Prisustvuje = value;
                    }
                    if (value == true && PrisustvoId == 0)
                    {
                        var searchRequest = new ClanPrisustvoSearchRequest()
                        {
                            TreningId = Id
                        };
                        var treninzi = AsyncHelpers.RunSync<List<Wellness.Model.ClanPrisustvo>>(() => _apiService_ClanPrisustvo.Get<List<Wellness.Model.ClanPrisustvo>>(searchRequest));
                        if (treninzi.Count == MaxPrisutnih)
                        {
                            _Prisustvuje = false;
                            PopupNavigation.Instance.PushAsync(new PopupView("Error", "Sva mjesta su vec popunjenja!"));
                        }


                        else
                        {
                            var insert = new Wellness.Model.Requests.ClanPrisustvoInsertRequest()
                            {
                                ClanId = ClanId,
                                TreningId = Id,
                                Prisustvovao = false,
                            };
                            var result = AsyncHelpers.RunSync<Wellness.Model.ClanPrisustvo>(() => _apiService_ClanPrisustvo.Insert<Wellness.Model.ClanPrisustvo>(insert));
                            PrisustvoId = result.Id;
                        }
                    }
                }

            }

        }


        public string PocetakKraj { get { return pocetak.ToString("HH:mm") + " - " + kraj.ToString("HH:mm"); } }
        public string TrenutnoMaxPrisutnih { get { return TrenutnoPrisutnih.ToString() + "/" + MaxPrisutnih.ToString(); } }
        public bool? OdrzanNeagitve
        {
            get
            {

                if (Odrzan == null)
                    return false;
                return !Odrzan;
            }
            set { OdrzanNeagitve = !Odrzan; }
        }
        public bool OcjenjenNeagtive
        {
            get { return !Ocjenjen; }
        }
        public bool? ClanPrisustvovaoTreninguNeagativ
        {
            get
            {
                return !ClanPrisustvovaoTreningu;
            }
        }










        
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }



    }
}
