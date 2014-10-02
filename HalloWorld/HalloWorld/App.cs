using System;
using Xamarin.Forms;

namespace HalloWorld
{
	public class App
	{
		public static Page GetMainPage ()
		{
			/*
			var button = new Button {
				Text = "Go to NextPage",
			};

			var page = new ContentPage {

				Content = new Label {
					Text = "Hello, World!",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},

				Content = new StackLayout{
					Children = {
						button,
					}
				}

			};

			var navPage = new NavigationPage (page);

			button.Clicked += (sender, e) => 
			{
			};

			return navPage;*/
			/*
			var tabs = new TabbedPage ();
			tabs.Children.Add (new NavigationPage (new HomePage ()){Title = "home"});
			tabs.Children.Add (new NavigationPage (new SecondPage ()){Title = "second"});
			tabs.Children.Add (new NavigationPage (new ThirdPage ()){Title = "third"});
			tabs.Children.Add (new NavigationPage (new FourthPage ()){Title = "fourth"});
			tabs.Children.Add (new NavigationPage (new FifthPage ()){Title = "fifth"});
			return tabs;
			*/
			//return new NavigationPage (new MyTabbedPage ());
			return new NavigationPage (new HomePage ());

		}

		public static Page GetTabbedPage ()
		{	

			var tabPage1 = new ContentPage () { 
				Title = "Page 1",
				Icon = "1.png",
				Content = new Label { 
					Text = "Page 1 Label",
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
				},
			};

			var label = new Label { 
				Text = "Page 2 Label",
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.Center,
			};

			var button = new Button {
				Text = "Page Name",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};

			var tabPage2 = new ContentPage () { 
				Title = "Page 2",
				Icon = "2.png",
				Content = new StackLayout {
					Children = {
						label,
						button,
					},
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
				},
				BackgroundColor = Color.FromHex("666666"),
			};

			var mainPage = new TabbedPage { 
				Children = {
					tabPage1,
					tabPage2,
				},
			};

			button.Clicked += (sender, e) => {
				mainPage.DisplayAlert("Alert Title", mainPage.CurrentPage.Title + " is selected.", "OK", "Cancel");
			};

			return mainPage;

		}

		public static Page GpsSamplePage()
		{
			var buttonStartGps = new Button
			{
				Text = "Start GPS"
			};

			var labelLatLon = new Label
			{
			};

			return new ContentPage
			{
				Content = new StackLayout
				{
					Orientation = StackOrientation.Vertical,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
						Children =
						{
							buttonStartGps,
							labelLatLon
						}
					}
			};
		}
	}
}

