using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp.Shared
{
    public class BookTour
    {
        public Guid BookTourID { get; set; }
        public String UserID { get; set; }
        public Guid TourID { get; set; }

        public DateTime TourStrartDate { get; set; }
        public DateTime TourEndDate { get; set; }

        public Tours Tours { get; set; }
        public Users Users { get; set; }
    }
}
