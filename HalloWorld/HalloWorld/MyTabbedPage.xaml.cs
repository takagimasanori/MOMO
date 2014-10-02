using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HalloWorld
{	
	public partial class MyTabbedPage : TabbedPage
	{	
		public MyTabbedPage ()
		{
			InitializeComponent ();

			Children.Add(new HomePage());
			Children.Add(new FourthPage());
			Children.Add(new SecondPage());
		}
	}
}

