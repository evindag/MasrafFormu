using Businnes.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete
{
    public class FisYonetimi : IFisService
    {
        IFisDal _fisDal;

        public FisYonetimi(IFisDal fisDal)
        {
            _fisDal = fisDal;
        }

        public List<Fis> GetAll()
        {
            return _fisDal.GetAll();
        }

        public List<Fis> GetAllFisId(int id)
        {
            return _fisDal.GetAll(f => f.FisId == id);
        }

        public List<Fis> GetByBelgeTarihi(decimal min, decimal max)
        {
            return _fisDal.GetAll(f => f.BelgeTarihi <= min && f.BelgeTarihi <= max);
        }

        public List<Fis> GetByFisTuru(string name)
        {
            return _fisDal.GetAll(f => f.FisTuru == name);
        }

        public List<Fis> GetByKisi(string name)
        {
            return _fisDal.GetAll(f => f.Kisi == name);
        }
    }
}
