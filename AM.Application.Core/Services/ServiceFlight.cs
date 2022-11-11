using AM.Application.Core.Domain;
using AM.Application.Core.Interfaces;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using AM.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AM.Application.Core.Services
{
    public class ServiceFlight : Service<Flight>, IServiceFlight
    {
        private readonly IUnitOfWork _unitofwork;
        public ServiceFlight(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitofwork = unitOfWork;
        }

        public IEnumerable<Flight> GetAll()
        {
            throw new NotImplementedException();
        }

        public Flight GetById(params object[] keyValues)
        {
            throw new NotImplementedException();
        }
    }

   





    
        /* public List<Flight> Flights { get; set; }


         public List<DateTime> GetFlightDates(String destination)
         {
             // List<DateTime> result = from flights in Fights where flights.Destination == destination select flights
             List<DateTime> result = new List<DateTime>();
             foreach (Flight f in Flights)
             {
                 if (f.Destination == destination)
                     result.Add(f.FlightDate);

             }
             return result;
         }

         public void GetFlights(String filterType, String value)
         {
             List<Flight> result = new List<Flight>();
             switch (filterType)
             {
                 case "FlightDate":
                     {

                         foreach (Flight f in Flights)
                         {
                             if (f.FlightDate == DateTime.Parse(value))
                                 result.Add(f);

                         }
                         break;
                     }
                 case "destination":
                     {

                         foreach (Flight f in Flights)
                         {
                             if (f.Destination == value)
                                 result.Add(f);

                         }
                         break;
                     }
                 case "EffectiveArrival":
                     {

                         foreach (Flight f in Flights)
                         {
                             if (f.EffectiveArrival == DateTime.Parse(value))
                                 result.Add(f);

                         }
                         break;
                     }
                 default:
                     System.Console.WriteLine("check filter choice ");
                     break;


             }
             foreach (Flight f in result)
             {
                 System.Console.WriteLine(f.ToString());
             }




         }
         public int ProgrammedFlightNumber(DateTime startDate)
         {
             var querry = from f in Flights where DateTime.Compare(f.FlightDate, startDate) > 0 && (f.FlightDate - startDate).TotalDays <= 7 select f;

             var querry2 = Flights.Where(f => DateTime.Compare(f.FlightDate, startDate) > 0 && (f.FlightDate - startDate).TotalDays <= 7);
             return querry.Count();
         }

         public List<Flight> GetFlightDates(String destination)
         {
             var querry = Flights.Where(f => f.Destination == destination);
             return querry.ToList();
         }

         public void ShowFlightDetails(Plane p)
         {
             var querry=Flights.Where(f => f.Plane == p).Select(f => new { f.FlightDate, f.Destination });
             foreach(var flight in querry)
             {
                 Console.WriteLine("Date = "+flight.FlightDate+"Destination"+flight.Destination);    
             }
         }
         public int ProgrammedFlightNumber2(DateTime date)
         {
             var querry=Flights.Where(f => DateTime.Compare(f.FlightDate, date) > 0 && (f.FlightDate - date).TotalDays <=7);
             return querry.Count();
         }
         public Double DurationAverage(String destination)
         {
             var querry = Flights.Where(f => f.Destination == destination).Select(f => f.EstimatedDuration).Average();
             return querry;
         }

         public List<Flight> OrderedDurationFLights()
         {
             var querry =Flights.OrderByDescending(f => f.EstimatedDuration).ToList();
             return querry;
         }
         public List<Traveller> SeniorTravellers(Flight flight)
         {
             var querry = flight.Passengers.OfType<Traveller>().OrderBy(f => f.BirthDate);
             return querry.Take(3).ToList();

         }
         public void DestinationGroupedFlights()
         {
             var querry = Flights.GroupBy(f => f.Destination);
             foreach (var fligh in querry)
             {
                 Console.WriteLine("Destination  " + fligh.Key);
                 foreach (var fl in fligh)
                 {
                     Console.WriteLine("Decollage : " + fl.FlightDate);
                 }
             }

         }*/
        
}



