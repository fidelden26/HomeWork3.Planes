using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Planes
{
    public class Tu154 : Aircraft
    {
        public Tu154()
        {
            Name = "Tu154 m";
            Capacity = 150;
            LoadCapacity = 15000;
            FlightRange = 4000;
            Speed = 900;
        }

        public override double FindTime()
        {
            var t = FlightRange / Speed;
            return t;
        }
    }
}
