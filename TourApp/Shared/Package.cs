using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp.Shared
{
	public class Package
	{
		public Guid PackageID { get; set; }
		public Guid HotelID { get; set; }
		public Guid TourID { get; set; }
		public decimal cost { get; set; }

		public Hotels Hotels { get; set; }
		public Tours Tours { get; set; }
	}
}
