using AM.Application.Core.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Interfaces
{
    public interface IServicePlane : IService<Plane>
    {
        IList<Passenger> GetPassengers(Plane plane);
        IList<IGrouping<int, Flight>> GetFlights(int n);
        bool IsAvailablePlane(Flight flight, int n);
        void DeletePlanes();
        public int GetFlightNbre(Plane pl);
    }
}
