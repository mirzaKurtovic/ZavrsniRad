using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Mobile.Models;

namespace Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();

        Wellness.Model.Requests.ClanViewRequest _clan = null;

        public MainPage(Wellness.Model.Requests.ClanViewRequest clan)
        {
            InitializeComponent();

            _clan = clan;

            MasterBehavior = MasterBehavior.Popover;

            //MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
            
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {

                MenuPages.Clear();
                if(MenuPages.ContainsKey(id))
                {
                    MenuPages.Remove(id);
                }


                switch (id)
                {
                    //case (int)MenuItemType.Browse:
                    //    MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                    //    break;
                    //case (int)MenuItemType.About:
                    //    MenuPages.Add(id, new NavigationPage(new AboutPage()));
                    //    break;
                    case (int)MenuItemType.TreningPage:
                        MenuPages.Add(id, new NavigationPage(new TreningPage(_clan,false)));
                        break;
                    case (int)MenuItemType.Historija:
                        MenuPages.Add(id, new NavigationPage(new TreningPage(_clan,true)));
                        break;
                    case (int)MenuItemType.QRCode:
                        MenuPages.Add(id, new NavigationPage(new QRCodePage(_clan)));
                        break;
                    case (int)MenuItemType.ClanarinaPage:
                        MenuPages.Add(id, new NavigationPage(new ClanarinaPage(_clan)));
                        break;
                    case (int)MenuItemType.PostavkePage:
                        MenuPages.Add(id, new NavigationPage(new PostavkePage(_clan)));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}