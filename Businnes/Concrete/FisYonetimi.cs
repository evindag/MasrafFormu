using Businnes.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
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

        public IResult Add(Fis fis)
        {
            _fisDal.Add(fis);
            return new Result(true,"Fis eklendi.");
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
            //return _fisdal.getall(f => f.belgetarihi <= min && f.belgetarihi <= max);
            throw new NotImplementedException();
        }

        public List<Fis> GetByFisTuru(string name)
        {
            return _fisDal.GetAll(f => f.FisTuru == name);
        }

        public Fis GetById(int id)
        {
            return _fisDal.Get(f => f.FisId == id);
        }

        public List<Fis> GetByKisi(string name)
        {
            return _fisDal.GetAll(f => f.Kisi == name);
        }

        public List<FisDetailDto> GetFisDetails()
        {
            return _fisDal.GetFisDetails();
        }
    }
}
