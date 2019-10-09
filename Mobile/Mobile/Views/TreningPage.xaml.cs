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
        Wellness.Model.Requests.ClanViewRequest _clan = null;

        public TreningPage(Wellness.Model.Requests.ClanViewRequest clan)
        {
            InitializeComponent();
            _clan = clan;

            BindingContext = new TreningViewModel(clan);

        }

        private void dataGrid_ValueChanged(object sender, Syncfusion.SfDataGrid.XForms.ValueChangedEventArgs e)
        {

        }

        private void dataGrid_GridDoubleTapped(object sender, Syncfusion.SfDataGrid.XForms.GridDoubleTappedEventArgs e)
        {

        }
    }
}