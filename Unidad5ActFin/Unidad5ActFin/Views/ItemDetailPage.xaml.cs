using System.ComponentModel;
using Unidad5ActFin.ViewModels;
using Xamarin.Forms;

namespace Unidad5ActFin.Views
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