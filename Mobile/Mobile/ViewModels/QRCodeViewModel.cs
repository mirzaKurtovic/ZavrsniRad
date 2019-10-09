using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mobile.ViewModels
{
    class QRCodeViewModel:BaseViewModel
    {
        public byte[] Image { get; set; }
        public Wellness.Model.Requests.ClanViewRequest _clan = null;
        public QRCodeViewModel(Wellness.Model.Requests.ClanViewRequest clan)
        {
            _clan = clan;
            Image = _clan.Qrcode;
            InitCommand = new Command(async () => await Init());

        }
        public QRCodeViewModel()
        {

        }

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            Image = _clan.Qrcode;
        }
    }
}
