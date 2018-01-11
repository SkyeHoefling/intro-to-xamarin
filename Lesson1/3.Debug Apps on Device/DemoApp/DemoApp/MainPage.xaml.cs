using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "This is an alert!", "OK");
        }

        private async void NavigateToListPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListPage());
        }
    }
}
