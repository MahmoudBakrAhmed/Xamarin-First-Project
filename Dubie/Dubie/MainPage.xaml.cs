using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Dubie
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            // Start animation
            await Task.WhenAll(
                SplashGrid.FadeTo(0, 2000),
                Logo.ScaleTo(10, 2000)
                );
        }

        async void MyLocationButtonFunction(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MyLocationsPage());
        }
    }
}
