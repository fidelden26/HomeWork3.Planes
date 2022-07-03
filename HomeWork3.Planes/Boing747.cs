using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Planes
{
    public class Boing747 : Aircraft
    {
        public Boing747()
        {
            Name = "Boing747";
            Capacity = 200;
            LoadCapacity = 17000;
            FlightRange = 14000;
            Speed = 910;
        }

        public override double FindTime()
        {
            var t = FlightRange / Speed;
            return t;
        }
    }
}
