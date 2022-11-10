using AM.Application.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Core.Interfaces
{
    public interface IServicePlane
    {
        public void Add(Plane plane);
        public void Remove(Plane plane);
        public void Update(Plane plane);
        public IList<Plane> GetAll();
    }
}
