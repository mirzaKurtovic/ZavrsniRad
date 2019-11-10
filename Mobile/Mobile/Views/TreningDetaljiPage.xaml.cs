using Mobile.ViewModels;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wellness.Mobile.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TreningDetaljiPage : ContentPage
    {


        Wellness.Model.Requests.ClanViewRequest _clan;
        APIService _apiService_Trening;
        APIService _apiService_ClanPrisustvo;
        TreningDetaljiViewModel model = null;
        public TreningDetaljiPage(Wellness.Model.Trening trening, Wellness.Model.Requests.ClanViewRequest clan)
        {
            InitializeComponent();

            _clan = clan;
            _apiService_Trening = new APIService("Trening");
            _apiService_ClanPrisustvo = new APIService("ClanPrisustvo");
            BindingContext = model = new TreningDetaljiViewModel(trening, clan);



            if (model.TreningMod.Ocjenjen == true)
            {

                rating.Value = model.TreningMod.Ocjena;
                rating.ReadOnly = true;

            }
            else
            {
                if (model.TreningMod.Odrzan == true && model.TreningMod.ClanPrisustvovaoTreningu==true)
                {
                    rating.ReadOnly = false;
                }
            }
            if (model.TreningMod.Odrzan == false || model.TreningMod.Odrzan == null)
            {
                rating.ReadOnly = true;
            }
            
        
        }

        private void rating_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }

        private async void rating_ValueChanged(object sender, Syncfusion.SfRating.XForms.ValueEventArgs e)
        {



            var clanPrisustvoInsertRequest = new Wellness.Model.Requests.ClanPrisustvoInsertRequest()
            {
                ClanId = model.TreningMod.ClanId,
                Ocjena =(int)rating.Value,
                Prisustvovao = true,
                TreningId = model.TreningMod.Id
            };

            var result = await _apiService_ClanPrisustvo.Update<Wellness.Model.ClanPrisustvo>(model.TreningMod.PrisustvoId, clanPrisustvoInsertRequest);

            await PopupNavigation.Instance.PushAsync(new PopupView("Success", "Uspjesno ste ocijenili trening !"));
            rating.ReadOnly = true;

        }
    }
}