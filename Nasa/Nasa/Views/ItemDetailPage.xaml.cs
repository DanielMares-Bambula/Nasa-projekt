using Nasa.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Nasa.Views
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