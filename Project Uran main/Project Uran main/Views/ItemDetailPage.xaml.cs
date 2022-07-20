using Project_Uran_main.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Project_Uran_main.Views
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