using Project_Uran_main.ViewModels;
using Project_Uran_main.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Project_Uran_main
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(Artsystem), typeof(Artsystem));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
