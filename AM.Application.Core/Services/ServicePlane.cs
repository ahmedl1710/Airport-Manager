using AM.Application.Core.Domain;
using AM.Application.Core.Interfaces;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServicePlane : Service<Plane>, IServicePlane
    {
        private readonly IUnitOfWork _unitOfWork;
        public ServicePlane (IUnitOfWork unitofwork) : base(unitofwork)
        {
            _unitOfWork = unitofwork;
        }

        public IEnumerable<Plane> GetAll()
        {
            throw new NotImplementedException();
        }

        public Plane GetById(params object[] keyValues)
        {
            throw new NotImplementedException();
        }


















        /*private IUnitOfWork unitOfWork;
        private IGenericRepository<Plane> genericRepository;
        /*public ServicePlane(IGenericRepository<Plane> genericRepository)
        {
            this.genericRepository = genericRepository;
        }
        public ServicePlane(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Add(Plane plane)
        {
            unitOfWork.Repository<Plane>().Add(plane);
        }

        public IList<Plane> GetAll()
        {
            return unitOfWork.Repository<Plane>().GetAll().ToList();
        }

        public void Remove(Plane plane)
        {
            unitOfWork.Repository<Plane>().Delete(plane);
        }

        public void Update(Plane plane)
        {
            unitOfWork.Repository<Plane>().Update(plane);
        }*/
    }
}
