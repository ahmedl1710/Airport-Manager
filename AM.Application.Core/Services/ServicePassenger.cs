using AM.Application.Core.Domain;
using AM.Application.Core.Interfaces;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Services
{
    public class ServicePassenger : Service<Passenger>, IServicePassenger
    {
        private readonly IUnitOfWork _unitOfWork;   
        public ServicePassenger(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork=unitOfWork; 
        }

        public void DestinationGroupedFlights()
        {
            throw new NotImplementedException();
        }

        public double DurationAverage(string destination)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Passenger> GetAll()
        {
            throw new NotImplementedException();
        }

        public Passenger GetById(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public List<Flight> GetFlightDates(string destination)
        {
            throw new NotImplementedException();
        }

        public void GetFlights(string filterType, string value)
        {
            throw new NotImplementedException();
        }

        public List<Flight> OrderedDurationFLights()
        {
            throw new NotImplementedException();
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            throw new NotImplementedException();
        }

        public int ProgrammedFlightNumber2(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Traveller> SeniorTravellers(Flight flight)
        {
            throw new NotImplementedException();
        }

        public void ShowFlightDetails(Plane p)
        {
            throw new NotImplementedException();
        }
    }
}
