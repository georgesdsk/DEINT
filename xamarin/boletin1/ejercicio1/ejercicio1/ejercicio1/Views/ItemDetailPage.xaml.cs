using ejercicio1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ejercicio1.Views
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