using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreClassLibrary
{
  public  class Seat
    {
        //Based on required properties
        public bool Booked { get; set; } = false;
        public string AdultorChild { get; set;}

        //constructor
        public Seat(bool booked, string adultOrChild)
        {
            Booked = booked;
            AdultorChild = adultOrChild;
        }
    }
}
