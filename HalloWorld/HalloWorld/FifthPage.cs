using System;
using Xamarin.Forms;

namespace HalloWorld
{
	public class FifthPage : ContentPage
	{
		public FifthPage ()
		{
			var editorName = new Entry {
				Keyboard = Keyboard.Text,
				Placeholder = "Input your name.",
			};

			var editorAge = new Entry {
				Keyboard = Keyboard.Text,
				Placeholder = "Input your age.",
			};

			var button = new Button {
				Text = "Push me",
				HorizontalOptions = LayoutOptions.Fill,
			};

			button.Clicked += (sender, e) => 
			{
				string[] yourData = {editorName.Text,editorAge.Text};
				Navigation.PushAsync(new NextPage(yourData));
			};

			Content = new StackLayout {
				Children =
				{
					editorName,
					editorAge,
					button,
				}
			};
		}
	}

	public class NextPage : ContentPage
	{
		public NextPage(string[] str)
		{
			Content = new Label
			{
				Text = "Your name is "+str[0]+ ". Your age is " + str[1]+ ".",

			};
		}
	}
}

