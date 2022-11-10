using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Ticket
    {
        public int NumTicket { get; set; }
        public int PassengerFk { get; set; }
       
        public virtual Passenger passenger { get; set; }
        public int FlightFk { get; set; }
        public virtual Flight flight  { get; set; }
        public float prix { get; set; }
        public String Siege { get; set; }
        public bool VIP { get; set; }
    }
}
