using System;
using Xamarin.Forms;

namespace SimpleApp.NoStyles
{
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            BindingContext = new
            {
                Description = "Welcome to Xamarin Intro Class!",
                ButtonText = "More Complex Page"
            };
		}

        private async void Alert_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "This is an alert message", "OK");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OouiSamplePage());
        }
    }
}
