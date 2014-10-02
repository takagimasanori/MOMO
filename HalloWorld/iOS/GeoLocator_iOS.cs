using System;
using MonoTouch.CoreLocation;
using Xamarin.Forms;
using HalloWorld;
using HolloWorld.iOS;

[assembly: Dependency (typeof (GeoLocator_iOS))]

namespace HolloWorld.iOS
{
	public class GeoLocator_iOS : IGeolocator
	{

		public event LocationEventHandler LocationReceived;

		private readonly CLLocationManager _locationMan = new CLLocationManager();

		public void StartGps(){
			_locationMan.LocationsUpdated += (sender, e) => 
			{
				if (this.LocationReceived != null) {
					var l = e.Locations[e.Locations.Length - 1];

					this.LocationReceived(this, new LocationEventArgs
						{
							Latitude = l.Coordinate.Latitude,
							Longitude = l.Coordinate.Longitude
						});
				}
			};
			_locationMan.StartUpdatingLocation();
		}
	}
}

