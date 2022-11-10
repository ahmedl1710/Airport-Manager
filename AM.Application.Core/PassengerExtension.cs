using AM.Application.Core.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public static class PassengerExtension
    {
        public static void UpperFullName(this Passenger p)
        {
            p.funame.FirstName = p.funame.FirstName[0].ToString().ToUpper()+p.funame.FirstName.Substring(1);
            p.funame.LastName = p.funame.LastName[0].ToString().ToUpper()+p.funame.LastName.Substring(1);

        }

    }
}
