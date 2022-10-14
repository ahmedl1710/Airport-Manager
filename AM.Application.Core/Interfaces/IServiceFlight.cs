using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Interfaces
{
    internal interface IServiceFlight
    {

        public List<DateTime> GetFlightDates(String destination);
        public void GetFlights(String filterType, String value);
    }
}
