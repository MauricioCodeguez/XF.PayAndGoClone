using PayAndGoClone.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PayAndGoClone
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Device.SetFlags(new string[] { "CarouselView_Experimental", "IndicatorView_Experimental" });

            MainPage = new NavigationPage(new MainPage());
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
