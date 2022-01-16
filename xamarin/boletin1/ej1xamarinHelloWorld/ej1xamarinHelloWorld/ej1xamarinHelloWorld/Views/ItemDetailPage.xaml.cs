using ej1xamarinHelloWorld.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ej1xamarinHelloWorld.Views
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