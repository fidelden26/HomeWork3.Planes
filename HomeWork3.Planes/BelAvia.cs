using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Planes
{
    public class BelAvia
    {
        public void Collating(List<Aircraft> collating)
        {
            collating.Sort(delegate (Aircraft x, Aircraft y)
            {
                if (x == null && y == null) return 0;
                else if (x == null) return -1;
                else if (x == null) return 1;
                else
                    return x.FlightRange.CompareTo(y.FlightRange);

            });

            foreach (var item in collating)
            {
                Console.WriteLine($"name:->{item.Name}  \t  capacity-{item.Capacity}  \t  load capacity-{item.LoadCapacity} kg  \t  flight range-{item.FlightRange} km  \t  speed-{item.Speed} km/h  \t  travel time-{item.FindTime().ToString("##.##")}");

            }
        }

        public void SumCapacity(List<Aircraft> aircraft)
        {
            double sumCapacity = 0;
            double sumLoadCapacity = 0;
            foreach (var sum in aircraft)
            {
                sumCapacity += sum.Capacity;
                sumLoadCapacity += sum.LoadCapacity;
            }
            Console.WriteLine($"общая вместимость = {sumCapacity}, общий вес = {sumLoadCapacity}");
        }

        public void ChoosePlane(List<Aircraft> chois)
        {
            Console.WriteLine("Please, enter flight range");
            var range = double.TryParse(Console.ReadLine(), out var x);
            if (x > 16000 || x < 3900)
            {
                Console.WriteLine("You entered a number greater than 16000 or less than 3900");
            }
            else
            {
                foreach (var item in chois)
                {
                    if (x >= item.FlightRange)
                    {
                        Console.WriteLine($"name:->{item.Name}  \t  capacity-{item.Capacity}  \t  load capacity-{item.LoadCapacity} kg  \t  flight range-{item.FlightRange} km  \t  speed-{item.Speed} km/h  \t  travel time-{item.FindTime().ToString("##.##")}");
                    }
                }
            }
        }
    }
}
