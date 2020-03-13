using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DataBaseServices.View;

namespace DataBaseServices
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Application.Current.Properties["ValorGuardado"] = 25;
            MainPage = new CarroView();

            //MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
