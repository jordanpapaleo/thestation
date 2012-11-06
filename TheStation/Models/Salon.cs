using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheStation.Models
{
	public static class Salon
	{
		public static string Name = "The Station Hair Studio";
		public static string PhoneNumber = "(720) 459-8816";
		public static Address Address = new Address()
		{
			Street = "1120 Delaware St., Suite 120",
			City = "Denver",
			State = "CO",
			ZipCode = 80204,
			Lat = 39.7339834,
			Long = -104.9929476

		};
		public static string Email = "thestationhairstudio@gmail.com";
		public static Hours Hours = new Hours()
		{
			Weekday = new KeyValuePair<DateTime,DateTime> (new DateTime(2012, 1, 1, 9, 00, 0), new DateTime(2012, 1, 1, 17, 00, 0)),
			Weekend = new KeyValuePair<DateTime,DateTime> (new DateTime(2012, 1, 1, 9, 00, 0), new DateTime(2012, 1, 1, 17, 00, 0)),
		};
	}

	public class Address
	{
		public string Street;
		public string City;
		public string State;
		public int ZipCode;
		public double Lat;
		public double Long;
	}

	public class Hours
	{
		public KeyValuePair<DateTime, DateTime> Weekday;
		public KeyValuePair<DateTime, DateTime> Weekend;
	}
}