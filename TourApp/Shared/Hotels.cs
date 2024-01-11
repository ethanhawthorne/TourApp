using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp.Shared
{
    public class Hotels
    {
        public Guid HotelID {  get; set; }
        public string HotelName { get; set; }

        public string RoomType { get; set;}

        public decimal Cost { get; set; }

        public int AvailableSpaces { get; set; }
    }
}
