
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

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HalloWorld.Android
{
	[Activity (Label = "MyWebApiPage_json")]			
	public class MyWebApiPage_json : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here

			string url = "http://oasis.mogya.com/api/v0/search?n=34.70849&w=135.48775&s=34.69727&e=135.50951";

			var request = HttpWebRequest.Create(string.Format(@"http://oasis.mogya.com/api/v0/search?n=34.70849&w=135.48775&s=34.69727&e=135.50951"));
			request.ContentType = "application/json";
			request.Method = "GET";

			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
			{
				if (response.StatusCode != HttpStatusCode.OK)
					Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
				using (StreamReader reader = new StreamReader(response.GetResponseStream()))
				{
					var content = reader.ReadToEnd();
					if(string.IsNullOrWhiteSpace(content)) {
						Console.Out.WriteLine("Response contained empty body...");
					}
					else {
						//Console.Out.WriteLine("Response Body: \r\n {0}", content);
						JObject jo = JObject.Parse (content);

						foreach (JProperty jp in jo.Properties()) {
							//Console.Out.WriteLine("type : " +jp.Value.Type.ToString());
							Console.Out.WriteLine (jp.Name + "-->" + jp.Value.ToString ());
						}



						Console.Out.WriteLine("********************************");

						/*
						var venues = JArray.Parse().SelectMany(groups => groups["items"])
							.Select(items => items["venue"]).Select(venue =>
								{
									var location = venue["location"];
									return new MyJson()
									{
										entry_id = (int)venue["entry_id"],
										address = (string)venue["address"],
									};
								});

						foreach (var venue in venues)
						{
							Console.Out.WriteLine(venue.entry_id);

						}*/

						MyJson.RootObject tttt = JsonConvert.DeserializeObject<MyJson.RootObject> (content);
						Console.Out.WriteLine (tttt.results[0].address);

						//MyJson data = JsonConvert.SerializeObject(content);
						//MyJson data = JsonConvert.SerializeObject (jo);
						//Console.Out.WriteLine (data.address.ToString());

						Console.Out.WriteLine("********************************");

						/*
						var serializer = new DataContractJsonSerializer (typeof(MyJson));
						using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(content))){
							var myjsondata = (MyJson)serializer.ReadObject(ms);
							Console.Out.WriteLine (myjsondata.address);
						}
						Console.Out.WriteLine("********************************");
						*/

					}
				}
			}
		}
	}
}

