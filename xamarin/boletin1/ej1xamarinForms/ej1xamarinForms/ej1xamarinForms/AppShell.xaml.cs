using ej1xamarinForms.ViewModels;
using ej1xamarinForms.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ej1xamarinForms
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
