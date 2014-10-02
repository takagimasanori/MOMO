
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Json;
using System.Xml;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace HalloWorld.Android
{
	[Activity (Label = "MyWebApiPage2")]			
	public class MyWebApiPage2 : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here

			string url = "http://oasis.mogya.com/api/v0/search?n=34.70849&w=135.48775&s=34.69727&e=135.50951";
			var req = WebRequest.Create (url);
			var res = req.GetResponse ();
			WebClient wc = new WebClient();
			wc.Headers.Add ("Content-Type","application/json");
		}
	}
}

