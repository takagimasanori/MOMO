using System;
using System.Collections.Generic;

namespace HalloWorld.Android
{
	public class MyJson
	{
		public class Result{
			public int entry_id { get; set; }
			public string address { get; set; }
			public string latitude { get; set; }
			public string longitude { get; set; }
			public string url_pc { get; set; }
			public string wireless { get; set; }
			public string powersupply { get; set; }
			public string tel { get; set; }
			public string other { get; set; }
			public string tag { get; set; }
			public string title { get; set; }
			public string url_title { get; set; }
			public string status { get; set; }
			public object edit_date { get; set; }
			public List<string> category { get; set; }
			public string mo_url { get; set; }
			public string icon { get; set; }
			public string icon_powerframe { get; set; }
		}
		public class RootObject
		{
			public List<Result> results { get; set; }
			public string status { get; set; }
		}
	}
}

