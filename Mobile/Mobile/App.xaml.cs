using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Mobile.Services;
using Mobile.Views;

namespace Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTU0NTE4QDMxMzcyZTMzMmUzMFpYT0RZazVYeUdkb252b21ZdlBJd1JlcGRyMGhJVHRVYlZKN1NZOVgvRVE9");

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
