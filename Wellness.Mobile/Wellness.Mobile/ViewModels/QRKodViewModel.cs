using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Wellness.Mobile.ViewModels
{
    public class QRKodViewModel
    {
        public byte[] Image { get; set; }
        public Model.Requests.ClanViewRequest _clan = null;
        public QRKodViewModel(Model.Requests.ClanViewRequest clan)
        {
            _clan = clan;
            Image = _clan.Qrcode;
            InitCommand = new Command(async () => await Init());

        }
        public QRKodViewModel()
        {

        }

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            Image = _clan.Qrcode;
        }


    }
}
