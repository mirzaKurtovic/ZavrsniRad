using Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TreningPage : ContentPage
    {

        APIService _apiService_Trening = new APIService("Trening");
        APIService _apiService_ClanPrisustvo = new APIService("ClanPrisustvo");
        bool historyOnly = false;
        Wellness.Model.Requests.ClanViewRequest _clan = null;

        public TreningPage(Wellness.Model.Requests.ClanViewRequest clan=null,bool historyOnly = false)
        {
            InitializeComponent();
            _clan = clan;
            this.historyOnly = historyOnly;
            BindingContext = new TreningViewModel(clan,historyOnly);
            
        }

        private void dataGrid_ValueChanged(object sender, Syncfusion.SfDataGrid.XForms.ValueChangedEventArgs e)
        {

        }


        private async void dataGrid_GridDoubleTapped(object sender, Syncfusion.SfDataGrid.XForms.GridDoubleTappedEventArgs e)
        {
            var rowData = (Mobile.Models.TreningModel)e.RowData;


            if (rowData == null)
                return;

            var trening = await _apiService_Trening.GetById<Wellness.Model.Trening>(rowData.Id);

            await Navigation.PushAsync(new TreningDetaljiPage(trening, _clan));
        }

        private void dataGrid_GridViewCreated(object sender, Syncfusion.SfDataGrid.XForms.GridViewCreatedEventArgs e)
        {
            dataGrid.Columns[5].IsHidden = historyOnly;

        }


    }
}