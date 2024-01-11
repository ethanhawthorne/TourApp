using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp.Shared
{
    public class HotelAvailability
    {
        public Guid HotelAvailabilityID { get; set; }
        public Guid HotelID { get; set; }

        public DateTime AvailableFrom {  get; set; }
        public DateTime AvailableTo { get; set;}

        public Hotels Hotels { get; set; }
    }
}
