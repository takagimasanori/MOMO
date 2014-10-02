using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HalloWorld
{	
	public partial class DataPage : ContentPage
	{	
		public DataPage ()
		{
			InitializeComponent ();
		}

		void OnClick(object sender, EventArgs agrs)
		{
			string[] yourData = {text1.Text,text2.Text};
			Navigation.PushAsync (new NextPage (yourData));
		}
	}
}

