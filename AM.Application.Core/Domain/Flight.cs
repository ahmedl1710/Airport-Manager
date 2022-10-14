using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Flight
    {
       
        public String Destination { get; set; }
        public String Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        public virtual ICollection<Passenger> Passengers { get; set; }
        public virtual Plane Plane { get; set; }

        public override string? ToString()
        {
            return "FlightDate " + FlightDate + "destination" + Destination + "depart" + Departure + "EffectiveArrival" + EffectiveArrival + "EstimatedDuration" + EstimatedDuration    ;
        }
    }
    

    
}
