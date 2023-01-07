using AM.Application.Core.Domain;
using AM.Application.Core.Interfaces;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Services
{
    public class ServicePassenger : Service<Passenger>, IServicePassenger
    {
        public List<Passenger> Passengers =>  GetAll().ToList();
        public ServicePassenger(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            
        }

      
    }
}
