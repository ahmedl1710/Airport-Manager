
using AM.Application.Core.Domain;
using AM.Application.Core.Services;
using AM.ApplicationCore;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using AM.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;

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
            /*  ServiceFlight sf = new ServiceFlight();
                  List<Flight> listFlights = new List<Flight>();
              sf.Flights = TestData.listFlights;
            */
            /*
             * System.Console.WriteLine("destination plz");
            String des = System.Console.ReadLine(); 
            List <DateTime> l =sf.GetFlightDates(des);
            foreach(DateTime f in l)
            {
                System.Console.WriteLine(f.ToString());
            }
         */
            //  sf.GetFlights("destination", "Paris");

            /*  AMContext context = new AMContext();
              context.Flights.Add(TestData, flight2);
              context.SaveChanges();

              */
            /*ServiceFlight sf = new ServiceFlight();

            sf.Flights = TestData.listFlights;

            //sf.FlightDetailsDel(TestData.BoingPlane);

            AMContext context = new AMContext();

            //Console.WriteLine(context.Flights.First());

            /*GenericRepository<Plane> genericRepository = new GenericRepository<Plane>(context);
            ServicePlane sp=new ServicePlane(genericRepository);*/
            /* UnitOfWork ui = new UnitOfWork(context, typeof(GenericRepository<>));
             ServicePlane sp = new ServicePlane(ui);
             sp.Add(TestData.BoingPlane);
             ui.Save();
             System.Console.WriteLine(context.Plane.First());
            */


            AMContext context = new AMContext();
            UnitOfWork ui = new UnitOfWork(context, typeof(GenericRepository<>));
            ServicePlane sp = new ServicePlane(ui);
          //  sp.Add(TestData.Airbusplane);
            //sp.Add(TestData.BoingPlane);
            sp.Delete(TestData.Airbusplane);
            sp.Delete(TestData.Airbusplane);




        }
    }
}