using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
    using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Plane
    {
        [Range(0,int.MaxValue)]
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
           
        public int planeId { get; set; }
        public PlaneType PlaneType { get; set; }
        public virtual ICollection<Flight> flights { get; set; }

        public override string? ToString()
        {
            String S= "plane ID"+ planeId+ "Capacity"+ Capacity+ "Plane Type"+ PlaneType + "Manufacture Date"+ ManufactureDate;
            foreach (Flight f in flights)
            {
                S += f.ToString();
            }
            
            return S; 
        }
    }
    public enum PlaneType { Boing=1, Airbus=2}
}
