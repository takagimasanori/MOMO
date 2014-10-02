
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Json;
using System.Xml;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace HalloWorld.Android
{
	[Activity (Label = "MyWebApiPage")]			
	public class MyWebApiPage : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			//SetContentView (Resource.Layout.MyWebApiLayoutPage);
			/*
			string url = "http://search.twitter.com/search.json?q=xamarin&rpp=10&include_entities=false&result_type=mixed";
			var httpReq = (HttpWebRequest)HttpWebRequest.Create (new Uri (url));

			httpReq.BeginGetResponse ((ar) => {
				var request = (HttpWebRequest)ar.AsyncState;
				using (var response = (HttpWebResponse)request.EndGetResponse (ar)){                          
					var s = response.GetResponseStream ();
					var j = (JsonObject)JsonObject.Load (s);
					var results = (from result in (JsonArray)j ["results"]
						let jResult = result as JsonObject
						select jResult ["text"].ToString ()).ToArray ();
					RunOnUiThread (() => {
						ListAdapter = new ArrayAdapter<string> (this,
							Resource.Layout.MyWebApiLayoutPage, results);
					} );
				}
			} , httpReq);
			*/

			//叩くapi
			string url = "http://zip.cgis.biz/xml/zip.php?zn=2270067";
			string url2 = "http://api.gnavi.co.jp/ver1/RestSearchAPI/?keyid=51f5f326299170d9f6fcd947ad6e7e84&tel=050-5798-1326&sort=1";

			//郵便番号
			try{
				XmlTextReader myReader = new XmlTextReader(url);
				while(myReader.Read()){
					/*
								switch (myReader.NodeType) 
								{
								case XmlNodeType.Element: // The node is an Element. 
									Console.Write("<" + myReader.Name); 

									while (myReader.MoveToNextAttribute()) // Read attributes. 
										Console.Write(" " + myReader.Name + "='" + myReader.Value + "'"); 
									Console.WriteLine(">"); 
									break;
								};*/

					if(myReader.Name == "value"){
						while(myReader.MoveToNextAttribute()){
							Console.WriteLine(myReader.Name + " = " + myReader.Value); 
						}
					}
				}
			}catch{
				Console.Out.WriteLine("error");
			}

			//ぐるなび
			/*
			try{
				XmlTextReader myReader2 = new XmlTextReader(url2);
				while(myReader2.Read()){
					if(myReader2.IsStartElement()){
						Console.WriteLine(myReader2.Name + " = " + myReader2.ReadString());
					}
				}
			}catch{
				Console.Out.WriteLine("error");
			}
			*/

			var request = HttpWebRequest.Create(string.Format(@"http://zip.cgis.biz/xml/zip.php?zn=2270067"));
			request.ContentType = "application/xml";
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
						Console.Out.WriteLine("Response Body: \r\n {0}", content);

						XmlTextReader myXmlTextReader = new XmlTextReader (new System.IO.StringReader(content));
						while(myXmlTextReader.Read()){
							if(myXmlTextReader.Name == "value"){
								while(myXmlTextReader.MoveToNextAttribute()){
									Console.WriteLine(myXmlTextReader.Name + " = " + myXmlTextReader.Value); 
								}
							}
						}
						/*
						XmlDocument myXmlDoc = new XmlDocument ();
						myXmlDoc.LoadXml(content);

						Console.Out.WriteLine("*************************");
						Console.Out.WriteLine("DocumentElement is {0}\r\n", myXmlDoc.DocumentElement);
						Console.Out.WriteLine("DocumentType is {0}\r\n", myXmlDoc.DocumentType);
						Console.Out.WriteLine("GetElementsByTagName is {0}\r\n", myXmlDoc.GetElementsByTagName("id"));
						Console.Out.WriteLine("ChildNodes is {0}\r\n", myXmlDoc.ChildNodes);
						*/

						//XmlNodeList nodeList;
						//XmlNode root = myXmlDoc.DocumentElement;


						/*
						try{
							while(){

							}

						}catch{
							Console.Out.WriteLine("error");
						}*/

						/*
						try{
							XmlTextReader xtr = new XmlTextReader (url);


							while(xtr.Read()){
								if(xtr.IsStartElement()){

									switch(xtr.Name){
									case "state_kana":
										Console.Out.WriteLine("find state_kana\r\n");
										break;
									default:
										Console.Out.WriteLine("not found\r\n");
										break;
									}
									Console.Out.WriteLine("****************** \r\n");
									Console.Out.WriteLine("This is \r\n{0}",xtr.Name);
									Console.Out.WriteLine("NameTable is {0}",xtr.NameTable);
									Console.Out.WriteLine("NodeType is {0}",xtr.NodeType);
									Console.Out.WriteLine("Prefix is {0}",xtr.Prefix);
									Console.Out.WriteLine("LocalName is {0}",xtr.LocalName);
									Console.Out.WriteLine("LineNumber is {0}",xtr.LineNumber);
									Console.Out.WriteLine("LinePosition is {0}",xtr.LinePosition);
									Console.Out.WriteLine("Value is {0}", xtr.Value);
									Console.Out.WriteLine("Value Length is {0}", xtr.Value.Length);
									Console.Out.WriteLine("HasValue is {0}",xtr.HasValue);
									Console.Out.WriteLine("IsEmptyElemtent is {0}",xtr.IsEmptyElement);
									Console.Out.WriteLine("ReadState is {0}",xtr.ReadState);
									Console.Out.WriteLine("SchemaInfo is {0}",xtr.SchemaInfo);
									Console.Out.WriteLine("属性 is {0}",xtr.GetAttribute("state_kana"));
									//Console.Out.WriteLine("{0}",x)
								}
							}
						}catch{
							Console.Out.WriteLine("error");
						}
						*/


					}
				}
			}
		}
	}
}

