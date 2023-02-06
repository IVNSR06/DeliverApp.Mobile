using System;
namespace DeliverApp.Mobile.Models
{
	public class Address
	{
		public string Street { get; set; }
		public string Number { get; set; }
		public string ZipCode { get; set; }
		public string State { get; set; }
		public string Country { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
	}
}

