using System;
using DeliverApp.Mobile.Models.Enums;

namespace DeliverApp.Mobile.Models
{
	public class DeliverModel
	{
		public Person Recipient { get; set; }

		public Product Product { get; set; }

		public Address ShipmentAddress { get; set; }

		public Address DeliverAddress { get; set; }

        public PackageStatus Status { get; set; }

        public string TrackingNumber { get; set; }
	}
}

