﻿using System;
using Xamarin.Forms;
using Android.Content;
using Android.Locations;
using Android.OS;
using HalloWorld.Android;

[assembly: Dependency (typeof (GeoLocator_Android))]

namespace HalloWorld.Android
{
	public class GeoLocator_Android
	{
		public event LocationEventHandler LocationReceived;

		public void StartGps()
		{
			var context = Forms.Context;
			var locationMan = context.GetSystemService(Context.LocationService) 
				as LocationManager;

			locationMan.RequestLocationUpdates(LocationManager.GpsProvider, 0, 0, 
				new MyLocationListener(l =>
					{
						if (this.LocationReceived != null) {
							this.LocationReceived(this, new LocationEventArgs 
								{
									Latitude = l.Latitude,
									Longitude = l.Longitude
								});
						}
					}));
		}

		class MyLocationListener : Java.Lang.Object, ILocationListener
		{
			private readonly Action<Location> _onLocationChanged;

			public MyLocationListener(Action<Location> onLocationChanged)
			{
				_onLocationChanged = onLocationChanged;
			}

			public void OnLocationChanged(Location location)
			{
				_onLocationChanged(location);
			}

			public void OnProviderDisabled(string provider) { }
			public void OnProviderEnabled(string provider) { }
			public void OnStatusChanged(string provider, 
				Availability status, Bundle extras)  { }
		}
	}
}

