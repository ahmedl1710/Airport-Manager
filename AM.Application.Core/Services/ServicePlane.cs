using AM.Application.Core.Domain;
using AM.Application.Core.Interfaces;
using AM.ApplicationCore.Interfaces;



namespace AM.ApplicationCore.Services
{
    public class ServicePlane : Service<Plane>, IServicePlane
    {

        public ServicePlane(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public bool IsAvailablePlane(Flight flight, int n)
        {
            int capacity = Get(p => p.flights.Contains(flight) == true).Capacity;
            int nbPassengers = flight.tickets.Count();
            //return ;
            return capacity >= (nbPassengers + n);
        }

        public void DeletePlanes()
        {
            foreach (var plane in GetAll().Where(p => (DateTime.Now - p.ManufactureDate).TotalDays > 365 * 10).ToList())
            {
                Delete(plane);
                Commit();
            }
        }

        public IList<IGrouping<int, Flight>> GetFlights(int n)
        {
            return GetAll().OrderByDescending(p => p.planeId).Take(n).SelectMany(p => p.flights).GroupBy(f => f.Plane.planeId).ToList();
        }

        public IList<Passenger> GetPassengers(Plane plane)
        {
            return GetById(plane.planeId).flights.SelectMany(f => f.tickets.Select(t => t.passenger)).ToList();
        }

        public int GetFlightNbre(Plane plane)
        {
            return GetById(plane.planeId).flights.Count();
        }
    }
}
