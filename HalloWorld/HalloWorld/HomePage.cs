using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace HalloWorld
{
	public class HomePage : ContentPage
	{
		public HomePage ()
		{
			Command<Type> navigateCommand = 
				new Command<Type>(async (Type pageType) =>
					{
						if (pageType == null)
						{
							await this.DisplayAlert("HolloWorld", 
								"Page not yet implemented", "OK", null);
							return;
						}

						// Get all the constructors of the page type.
						IEnumerable<ConstructorInfo> constructors = 
							pageType.GetTypeInfo().DeclaredConstructors;

						foreach (ConstructorInfo constructor in constructors)
						{
							// Check if the constructor has no parameters.
							if (constructor.GetParameters().Length == 0)
							{
								// If so, instantiate it, and navigate to it.
								Page page = (Page)constructor.Invoke(null);
								await this.Navigation.PushAsync(page);
								break;
							}
						}
					});
			this.Title = "Home Page";
			this.Content = new TableView {
				Intent = TableIntent.Menu,
				Root = new TableRoot {
					new TableSection () 
					{
						new TextCell
						{
							Text = "item1(button)",
							Command = navigateCommand,
							CommandParameter = typeof(SecondPage),
						},

						new TextCell
						{
							Text = "item2(text)",
							Command = navigateCommand,
							CommandParameter = typeof(ThirdPage),
						},

						new TextCell
						{
							Text = "item3(image)",
							Command = navigateCommand,
							CommandParameter = typeof(FourthPage),
						},

						new TextCell
						{
							Text = "item4(data)",
							Command = navigateCommand,
							CommandParameter = typeof(FifthPage),
						},

						new TextCell
						{
							Text = "item5(alert)",
							Command = navigateCommand,
							CommandParameter = typeof(SixthPage),
						},

						new TextCell
						{
							Text = "item6(platform)",
							Command = navigateCommand,
							CommandParameter = typeof(SeventhPage),
						},
					},
				}
			};
		}
	}
}

