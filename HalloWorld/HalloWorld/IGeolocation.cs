using System;

namespace HalloWorld
{
	public class LocationEventArgs : EventArgs
	{
		public double Latitude { get; set;}
		public double Longitude { get; set;}
	}

	public delegate void LocationEventHandler(object sender, LocationEventArgs args);

	public interface IGeolocator
	{
		void StartGps();
		event LocationEventHandler LocationReceived;
	}
}
