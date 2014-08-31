using System;
using Xamarin.Forms;

namespace HalloWorld
{
	public class SecondPage : ContentPage
	{
		public SecondPage ()
		{
			Label header = new Label {
				Text = "Second Page",
				//Font = Font.BoldSystemFontOfSize(40),
				Font = Font.SystemFontOfSize(40,FontAttributes.Bold),
				HorizontalOptions = LayoutOptions.Center,
			};
			Button button = new Button {
				Text = "Button",
			};

			button.Clicked += (sender, e) => 
			{
				Navigation.PushAsync(new ThirdPage());
			};

			Content = new StackLayout {
				Children = {
					header,
					button,
				}
			};
		}
	}
}

