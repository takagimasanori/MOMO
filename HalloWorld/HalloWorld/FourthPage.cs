using System;
using Xamarin.Forms;
namespace HalloWorld
{
	public class FourthPage : ContentPage
	{
		public FourthPage ()
		{
			Title = "ImagePage";
			Label header = new Label
			{
				Text = "FourthPage",
				Font = Font.BoldSystemFontOfSize(30),
				HorizontalOptions = LayoutOptions.Center,
			};

			Image testImage = new Image{
				Aspect = Aspect.AspectFit,
				//Aspect = Aspect.AspectFill,
				Source = ImageSource.FromFile ("test.jpg"),
				//HeightRequest = 100,
				WidthRequest = 100,
				BackgroundColor = Color.Red,
			};
			//testImage.Source = ImageSource.FromFile ("test.jpg");

			ImageCell imageSource = new ImageCell {
				ImageSource = ImageSource.FromFile("test.jpg"),
			};

			TableView tableview = new TableView
			{
				Intent = TableIntent.Form,
				Root = new TableRoot
				{
					new TableSection
					{
						new ImageCell
						{
							ImageSource = ImageSource.FromFile("test.jpg"),
						}
					}
				}
			};

			this.Content = new StackLayout 
			{
				Children =
				{
					header,
					//tableview,
					testImage,
					//imageSource,
				}
			};

		}
	}
}

