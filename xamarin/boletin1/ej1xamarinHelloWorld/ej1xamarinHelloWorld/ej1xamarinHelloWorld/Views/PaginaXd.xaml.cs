using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ej1xamarinHelloWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaXd : ContentPage
    {
        public PaginaXd()
        {
            InitializeComponent();
        }

        private async void boton_Clicked(object sender, EventArgs e)
        {
            string nombre = entry.Text;
            await DisplayAlert("Alerta", "El mundo te saluda " + nombre,"ok");
        }
    }
}