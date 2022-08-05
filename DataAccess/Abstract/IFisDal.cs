using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IFisDal
    {
        List<Fis> GetAll();
        void Add(Fis fis);
        void Update(Fis fis);
        void Delete(Fis fis);

        List<Fis> GetAllById(int id);
    }
}
