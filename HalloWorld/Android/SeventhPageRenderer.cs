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
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;

using HalloWorld;
using HalloWorld.Android;

[assembly:ExportRenderer(typeof(HalloWorld.SeventhPage),typeof(HalloWorld.Android.SeventhPageRenderer))]

namespace HalloWorld.Android
{		
	public class SeventhPageRenderer : PageRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Page> e)
		{
			base.OnElementChanged (e);

			// this is a ViewGroup - so should be able to load an AXML file and FindView<>
			var activity = this.Context as Activity;

			var seventhActivity = new Intent (activity, typeof (SecondActivity));
			activity.StartActivity (seventhActivity);
		}
	}
}

