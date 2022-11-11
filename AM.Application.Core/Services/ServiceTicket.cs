using AM.Application.Core.Domain;
using AM.Application.Core.Interfaces;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using AM.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Services
{
    
    public class ServiceTicket : Service<Ticket>, IServiceTicket
    {
        private readonly IUnitOfWork _unitOfWork;
        public ServiceTicket(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Ticket> GetAll()
        {
            throw new NotImplementedException();
        }

        public Ticket GetById(params object[] keyValues)
        {
            throw new NotImplementedException();
        }
    }
}
