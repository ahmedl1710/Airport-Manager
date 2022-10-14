
using AM.Application.Core.Domain;
using AM.Application.Core.Services;
using AM.ApplicationCore;

namespace AM.UI.Console
 
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            /* var date1 = new DateTime(2022,9,30);
             Plane plane = new Plane(100, date1, boing);
             System.Console.WriteLine(plane.ToString);*/


            /*   
            Passenger p = new Passenger(); 
               Traveller t = new Traveller();  
               Staff s = new Staff();
            */
            ServiceFlight sf = new ServiceFlight();
                List<Flight> listFlights = new List<Flight>();
            sf.Flights = TestData.listFlights;
            /*
             * System.Console.WriteLine("destination plz");
            String des = System.Console.ReadLine(); 
            List <DateTime> l =sf.GetFlightDates(des);
            foreach(DateTime f in l)
            {
                System.Console.WriteLine(f.ToString());
            }
         */
            sf.GetFlights("destination", "Paris");




        }
    }
}