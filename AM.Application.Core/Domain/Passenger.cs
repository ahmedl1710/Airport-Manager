using Castle.Components.DictionaryAdapter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace AM.Application.Core.Domain
{
    using System.ComponentModel.DataAnnotations;
    using System.Reflection.Metadata.Ecma335;

    public class Passenger
    {

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Key]
        [MaxLength(7)]
        public int PassportNumber { get; set; }
        public String EmailAddress { get; set; }
        [MinLength(3, ErrorMessage = "First name doit etre supperieur a 3")]
        [MaxLength(25, ErrorMessage = "First name doit etre inferieur a 25")]
        /*public String FirstName { get; set; }
        public String LastName { get; set; }*/

        public FullName funame { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"[^0-9]{8}$", ErrorMessage = "numero doit contenir 8 chiffres")]
        public int TelNumber { get; set; }
        public virtual ICollection<Flight> flights { get; set; }
        public virtual ICollection<Ticket> tickets { get; set; }

        // Partie 3 : polymorphisme de surcharge 

        bool CheckProfile(String nom,String prenom)
        {
            if (this.funame.FirstName == nom && this.funame.LastName == prenom)
                return true;
            else return false;
            // return irstName == name && lastName == prenom;
        }
        bool CheckProfile(String nom, String prenom,String mail)
        {
            if (this.funame.FirstName == nom && this.funame.LastName == prenom && this.EmailAddress == mail)
                return true;
            else return false;
            //return irstName == name && lastName == prenom && EmailAdress == mail;
        }
        
        public virtual void PassengerType()
        {
            System.Console.WriteLine("iam a passenger");
        }


        
        public override String? ToString()
        {
           String S="First Name" + funame.FirstName + "Last Name" + funame.LastName + " Birth Date" + BirthDate + "Passport Number" + PassportNumber + "Email Address" + EmailAddress + "Tel Number" + TelNumber+"\n";
            foreach(Flight f in flights)
            {
                S+=f.ToString();
            }
            return S;

        }
    }
}

