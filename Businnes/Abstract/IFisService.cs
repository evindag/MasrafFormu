using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Abstract
{
    public interface IFisService
    {
        IDataResult<List<Fis>> GetAll();
        IDataResult<List<Fis>> GetAllFisId(int id);
        IDataResult<List<Fis>> GetByBelgeTarihi(string min,string max);
        IDataResult<List<Fis>> GetByFisTuru(string name);
        IDataResult<List<Fis>> GetByKisi(string name);
        IDataResult<Fis> GetById(int id);
        IResult Add(Fis fis);

        IDataResult<List<FisDetailDto>> GetFisDetails();
    }
}
