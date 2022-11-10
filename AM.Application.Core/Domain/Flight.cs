using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Flight
    {
        public int Id { get; set; }

        public String Destination { get; set; }
        public String Departure { get; set; }
        public String Airline { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        public virtual ICollection<Passenger> Passengers { get; set; }
        public virtual ICollection<Ticket> tickets { get; set; }
        
        public virtual Plane Plane { get; set; }

        public override string? ToString()
        {
            return "\t FlightDate " + FlightDate + "destination" + Destination + "depart" + Departure + "EffectiveArrival" + EffectiveArrival + "EstimatedDuration" + EstimatedDuration+"\n";
        }
    }
    

    
}
