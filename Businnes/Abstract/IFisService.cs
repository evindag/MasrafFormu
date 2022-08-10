using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Abstract
{
    public interface IFisService
    {
        List<Fis> GetAll();
        List<Fis> GetAllFisId(int id);
        List<Fis> GetByBelgeTarihi(decimal min,decimal max);
        List<Fis> GetByFisTuru(string name);   
        List<Fis> GetByKisi(string name);
    }
}
