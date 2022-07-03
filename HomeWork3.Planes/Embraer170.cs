using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Planes
{
    public class Embraer170 : Aircraft
    {
        public Embraer170()
        {
            Name = "Embraer170";
            Capacity = 120;
            LoadCapacity = 10000;
            FlightRange = 3900;
            Speed = 890;
        }

        public override double FindTime()
        {
            var t = FlightRange / Speed;
            return t;
        }
    }
}
