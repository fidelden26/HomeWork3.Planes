using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Planes
{
    public class AirBusA320 : Aircraft
    {
        public AirBusA320()
        {
            Name = "airBusA320";
            Capacity = 220;
            LoadCapacity = 10000;
            FlightRange = 6000;
            Speed = 840;
        }

        public override double FindTime()
        {
            var t = FlightRange / Speed;
            return t;
        }
    }
}
