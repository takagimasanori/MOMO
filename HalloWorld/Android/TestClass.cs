
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
using Newtonsoft.Json.Linq;

namespace HalloWorld.Android
{
	public class TestClass
	{
		public async Task<MyJson> GetTest(){
			var request = HttpWebRequest.Create(string.Format(@"http://oasis.mogya.com/api/v0/search?n=34.70849&w=135.48775&s=34.69727&e=135.50951"));
			request.ContentType = "application/json";
			request.Method = "GET";
			using (HttpWebResponse response = request.GetResponse () as HttpWebResponse) {
				if (response.StatusCode != HttpStatusCode.OK)
					Console.Out.WriteLine ("Error fetching data. Server returned status code: {0}", response.StatusCode);
				using (StreamReader reader = new StreamReader (response.GetResponseStream ())) {
					var content = reader.ReadToEnd ();
					if (string.IsNullOrWhiteSpace (content)) {
						Console.Out.WriteLine ("Response contained empty body...");
					} else {
						//Console.Out.WriteLine("Response Body: \r\n {0}", content);
						JObject jo = JObject.Parse (content);

						foreach (JProperty jp in jo.Properties()) {
							//Console.Out.WriteLine("type : " +jp.Value.Type.ToString());
							Console.Out.WriteLine (jp.Name + "-->" + jp.Value.ToString ());
						}
					}
				}
			}
		}

	}
}

