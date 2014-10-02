
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Webkit;

namespace HalloWorld.Android
{
	[Activity (Label = "HalloWorld.Android")]
	public class SecondActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.MySeventhPage);

			var button = FindViewById<Button> (Resource.Id.myButton);

			button.Click += (sender, e) => {
				//StartActivity(typeof(TimerActivity));//go to forms
				//StartActivity(typeof(MyWebApiPage));
				StartActivity(typeof(MyWebApiPage_json));
				//StartActivity(typeof(MyWebApiPage2));
			};


		}
	}
}

