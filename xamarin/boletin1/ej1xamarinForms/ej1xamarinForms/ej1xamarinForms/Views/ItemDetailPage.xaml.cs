using ej1xamarinForms.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ej1xamarinForms.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}