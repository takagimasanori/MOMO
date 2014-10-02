using System;
using Xamarin.Forms;

namespace HalloWorld
{
	public class MyGeolocationPage : ContentPage
	{
		public MyGeolocationPage ()
		{
			var buttonStartGps = new Button {
				Text = "Start GPS"
			};

			var labelLation = new Label {

			};

			buttonStartGps.Clicked += (sender, e) => 
			{
				var geoLocator = DependencyService.Get<IGeolocator>();
				geoLocator.LocationReceived += (object s, LocationEventArgs args) => 
				{
					labelLation.Text = String.Format("{0}/{1}",args.Latitude,args.Longitude);
				};
				geoLocator.StartGps();
			};
				
			Content = new StackLayout {
				Orientation = StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					buttonStartGps,
					labelLation,
				}
			};
		}
	}
}

