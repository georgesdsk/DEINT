using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ej1xamarinForms.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        private async void boton_Clicked(object sender, EventArgs e)
        {
            string nombre = entry.Text;
            await DisplayAlert("Alerta", "El mundo te saluda " + nombre, "ok");
        }
    }
}