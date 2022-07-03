using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Planes
{
    public class Aircraft
    {
        public string Name { get; protected set; }
        public double Capacity { get; protected set; }  //вместимость
        public double LoadCapacity { get; protected set; }  // грузоподъёмность
        public double FlightRange { get; protected set; }
        public double Speed { get; protected set; }

        public virtual double FindTime()
        {
            var t = FlightRange / Speed;
            return t;
        }
    }
}
