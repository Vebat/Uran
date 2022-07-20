using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project_Uran_main.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
       
        }

    

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Manualquadro());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Artsystem());
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Minedangerous());
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Ingeneer());
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Vto());
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Searching());
        }

        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Firstaid());
        }

        private void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Survive());
        }
    }
}