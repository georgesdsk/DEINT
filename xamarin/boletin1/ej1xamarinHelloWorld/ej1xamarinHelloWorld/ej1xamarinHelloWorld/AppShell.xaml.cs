using ej1xamarinHelloWorld.ViewModels;
using ej1xamarinHelloWorld.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ej1xamarinHelloWorld
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
