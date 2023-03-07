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
    public partial class BairrosPorCidade : ContentPage
    {
        public BairrosPorCidade()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}