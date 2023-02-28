using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppSearchCep.View;

namespace AppSearchCep
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new BairrosPorCidade());
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
