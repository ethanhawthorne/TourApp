using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp.Shared
{
    public class BookHotel
    {
        public Guid BookHotelID {  get; set; }
        public string UsersId { get; set; }
        public Guid HotelID { get; set; }

        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public Hotels Hotels { get; set; }
        public Users Users { get; set; }


    }
}
