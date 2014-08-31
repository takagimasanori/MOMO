using System;
using Xamarin.Forms;
using System.Diagnostics;

namespace HalloWorld
{
	public class SixthPage : ContentPage
	{
		public SixthPage ()
		{
			var alertButton1 = new Button { Text = "Alert Text", TextColor = Color.Blue };
			alertButton1.Clicked += async (sender, e) => 
			{
				await DisplayAlert("Title","You have been alerted","Yes", "No");
			};

			var alertButton2 = new Button{ Text = "Yes/No" };
			alertButton2.Clicked += async (sender, e) => 
			{
				var answer = await DisplayAlert("test", "Go to the NextPage", "HomePage", "Cancel");
				//Debug.WriteLine("Answer: " + answer);
				if(answer) await Navigation.PushAsync(new HomePage());
				//else await Navigation.PushAsync(new SecondPage());
				else alertButton2.Text = "Cancelされました";
			};

			var alertButton3 = new Button { Text = "ActionSheet" };
			alertButton3.Clicked += async (sender, e) => 
			{
				string str = await DisplayActionSheet("Title","Cancel","OK",
					new string[]{"item1","item2","item3"});
				if(str != null)
				{
					alertButton3.Text = str + " was selected.";
				}
			};

			Content = new StackLayout {
				Padding = new Thickness(0,20,0,0),
				Children = {
					alertButton1,
					alertButton2,
					alertButton3,
				}
			};
		}
	}
}

