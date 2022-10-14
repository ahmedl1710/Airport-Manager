using AM.Application.Core.Domain;
using AM.Application.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Fights { get; set; }


        public List<DateTime> GetFlightDates(String destination)
        { 
           // List<DateTime> result = from flights in Fights where flights.Destination == destination select flights
           List<DateTime> result = new List<DateTime>();    
            foreach (Flight f in Fights)
            {
                if (f.Destination == destination)
                    result.Add(f.FlightDate);
                   
            }
            return result;
                }

        public void GetFlights(String filterType,String value)
        {
            List<Flight> result = new List<Flight>();
            switch (filterType)
            {
                case "FlightDate":
                    {
                        
                        foreach (Flight f in Fights)
                        {
                            if (f.FlightDate == DateTime.Parse(value))
                                result.Add(f);

                        }
                        break;
                    }
                case "destination":
                    {
                        
                        foreach (Flight f in Fights)
                        {
                            if (f.Destination == value)
                                result.Add(f);

                        }
                        break;
                    }
                case "EffectiveArrival":
                    {
                        
                        foreach (Flight f in Fights)
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

        }
    }

