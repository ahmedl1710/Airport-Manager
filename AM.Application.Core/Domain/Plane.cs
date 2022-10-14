using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Plane
    {

     

        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int planeId { get; set; }
        public PlaneType PlaneType { get; set; }
        public virtual ICollection<Flight> flights { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
    public enum PlaneType { Boing, Airbus}
}
