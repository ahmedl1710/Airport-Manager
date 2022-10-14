using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AM.Application.Core.Domain
{
    public class Passenger
    {

        public DateTime BirthDate { get; set; }
        public int PassportNumber { get; set; }
        public String EmailAddress { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int TelNumber { get; set; }
        public virtual ICollection<Flight> flights { get; set; }

       
        // Partie 3 : polymorphisme de surcharge 

         bool CheckProfile(String nom,String prenom)
        {
            if (this.FirstName == nom && this.LastName == prenom)
                return true;
            else return false;
            // return irstName == name && lastName == prenom;
        }
        bool CheckProfile(String nom, String prenom,String mail)
        {
            if (this.FirstName == nom && this.LastName == prenom && this.EmailAddress == mail)
                return true;
            else return false;
            //return irstName == name && lastName == prenom && EmailAdress == mail;
        }
        
        public virtual void PassengerType()
        {
            System.Console.WriteLine("iam a passenger");
        }

    }
}

