using AppSearchCep.Model;
using AppSearchCep.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSearchCep.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuscaCepPorLogradouro : ContentPage
    {
        public BuscaCepPorLogradouro()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                carregando.IsVisible = true;
                carregando.IsRunning = true;

                List<Cep> arr_ceps = await DataService.GetCepsByLogradouro(txt_logradouro.Text);
                lst_ceps.ItemsSource = arr_ceps;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
            finally
            {
                carregando.IsVisible = false;
                carregando.IsRunning = false;
            }
        }
    }
}