using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Traveller : Passenger
    {
        public String HealthInformation { get; set; }
        public String Nationality { get; set; }

        
         public override void PassengerType()
        {
            System.Console.WriteLine("iam a traveller");
        }

        public override string? ToString()
        {
            String s = base.ToString();
            s += "\n Health Information  " + HealthInformation + "Nationality" + Nationality;
            return s;
        }
    }
}
