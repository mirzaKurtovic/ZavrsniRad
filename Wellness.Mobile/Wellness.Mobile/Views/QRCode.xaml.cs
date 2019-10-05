using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wellness.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wellness.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRCode : ContentPage
    {
        public QRCode(Model.Requests.ClanViewRequest clan)
        {
            InitializeComponent();
            BindingContext = new QRKodViewModel(clan);


                 

        }
    }
}