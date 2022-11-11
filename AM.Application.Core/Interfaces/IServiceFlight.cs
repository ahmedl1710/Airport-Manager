using AM.Application.Core.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Interfaces
{
    public interface IServiceFlight: IGenericRepository<Flight>   
    {

       /* public List<Flight> GetFlightDates(String destination);

        public void GetFlights(String filterType, String value);
        public int ProgrammedFlightNumber(DateTime startDate);
        public void ShowFlightDetails(Plane p);
        public int ProgrammedFlightNumber2(DateTime date);
        public Double DurationAverage(String destination);
        public List<Flight> OrderedDurationFLights();
        public List<Traveller> SeniorTravellers(Flight flight);
        public void DestinationGroupedFlights();
       */
    }
}
