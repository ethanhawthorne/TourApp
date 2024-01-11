using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp.Shared
{
    public class Tours
    {
        public Guid TourID {  get; set; }
        public string TourName { get; set; }
        public int Duration {  get; set; }
        public decimal Cost { get; set;}
        public int AvailibleSpaces {  get; set; }
    }
}
