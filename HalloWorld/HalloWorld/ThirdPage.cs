using System;
using Xamarin.Forms;

namespace HalloWorld
{
	public class ThirdPage : ContentPage
	{
		public ThirdPage ()
		{
			Label header = new Label {
				Text = "Third Page",
				Font = Font.BoldSystemFontOfSize(40),
				HorizontalOptions = LayoutOptions.Center,
			};

			Label label = new Label {
				Text = "texttexttexttexttexttexttexttexttexttexttexttexttexttexttexttexttexttexttexttexttexttext",
				Font = Font.SystemFontOfSize (20),
			};

			Content = new StackLayout {
				Children = {
					header,
					label,
				}
			};
		}
	}
}

