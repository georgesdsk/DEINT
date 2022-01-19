using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ejercicio1.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        async private void boton_Clicked(object sender, EventArgs e)
        {
            string nombre = entry.Text;
            await DisplayAlert("Alert", nombre, "OK");
        }
    }
}