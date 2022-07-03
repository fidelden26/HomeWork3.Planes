using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Planes
{
    public class Boing777 : Aircraft
    {
        public Boing777()
        {
            Name = "Boing777";
            Capacity = 270;
            LoadCapacity = 18000;
            FlightRange = 16000;
            Speed = 945;
        }

        public override double FindTime()
        {
            var t = FlightRange / Speed;
            return t;
        }
    }
}
