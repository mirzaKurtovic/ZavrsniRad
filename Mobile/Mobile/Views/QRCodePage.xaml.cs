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
    public partial class QRCodePage : ContentPage
    {
        Wellness.Model.Requests.ClanViewRequest _clan = null;

        public QRCodePage(Wellness.Model.Requests.ClanViewRequest clan)
        {
            InitializeComponent();

            _clan = clan;

            BindingContext = new QRCodeViewModel(clan);

        }
        public QRCodePage()
        {

        }
    }
}