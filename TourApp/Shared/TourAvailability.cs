using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp.Shared
{
    public class TourAvailability
    {
        public Guid TourAvailabilityID { get; set; }
        public Guid TourID { get; set; }

        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }

        public Tours Tours { get; set; }
    }
}
