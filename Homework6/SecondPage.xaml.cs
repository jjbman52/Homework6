using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Homework6
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }
        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void NavigateButton_OnClickedPage3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ThirdPage());
        }
    }
}
