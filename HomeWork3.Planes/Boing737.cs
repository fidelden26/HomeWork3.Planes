using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Planes
{
    public class Boing737 : Aircraft
    {
        public Boing737()
        {
            Name = "Boing737";
            Capacity = 225;
            LoadCapacity = 15000;
            FlightRange = 5000;
            Speed = 850;
        }

        public override double FindTime()
        {
            var t = FlightRange / Speed;
            return t;
        }
    }
}
