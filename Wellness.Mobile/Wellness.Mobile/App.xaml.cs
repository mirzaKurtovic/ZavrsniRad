using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Wellness.Mobile.Services;
using Wellness.Mobile.Views;

namespace Wellness.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //Register Syncfusion license v17.xx
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTUzMzUyQDMxMzYyZTM0MmUzMFBPYXByeWRRS0VHOHU5RTZFdUNkemdoRWlyWWUzYng0NTR4QWQwcVFZRzg9");
            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
