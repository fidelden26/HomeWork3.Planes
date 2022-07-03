namespace HomeWork3.Planes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aircraft> aircraftList = new List<Aircraft>();
            aircraftList.Add(new AirBusA320());
            aircraftList.Add(new Boing737());
            aircraftList.Add(new Boing747());
            aircraftList.Add(new Boing777());
            aircraftList.Add(new Embraer170());
            aircraftList.Add(new Tu154());

            BelAvia belAvia = new BelAvia();

            belAvia.Collating(aircraftList);
            belAvia.SumCapacity(aircraftList);
            belAvia.ChoosePlane(aircraftList);
        }
    }
}