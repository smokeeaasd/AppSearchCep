using AppSearchCep.Model;
using AppSearchCep.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSearchCep.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CidadePorEstado : ContentPage
    {
        ObservableCollection<Cidade> lista_cidades = new ObservableCollection<Cidade>();
        public CidadePorEstado()
        {
            InitializeComponent();

            lst_cidades.ItemsSource = lista_cidades;
        }

        private async void pck_uf_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                act_carregando.IsVisible = true;
                act_carregando.IsRunning = true;

                Picker disparador = sender as Picker;

                string uf = disparador.SelectedItem.ToString();

                List<Cidade> lst_cidades = await DataService.GetCidadesByUF(uf);

                lista_cidades.Clear();

                lst_cidades.ForEach(c => lista_cidades.Add(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.StackTrace, "OK");
            }
            finally
            {
                act_carregando.IsVisible = false;
                act_carregando.IsRunning = false;
            }
        }
    }
}