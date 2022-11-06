using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmployementDate { get; set; }
        public String Function { get; set; }
        [DataType(DataType.Currency)]
        public float Salary { get; set; }

        
        public override void PassengerType()
        {
            System.Console.WriteLine("iam a staff");
        }

        public override string? ToString()
        {
            String s =base.ToString();
            s += "\n Employement Date " + EmployementDate + "Function" + "Salary" + Salary;
            return s;
        }
    }
}
