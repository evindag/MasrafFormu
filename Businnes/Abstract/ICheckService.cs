using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICheckService
    {
        IDataResult<List<Check>> GetAll();
        IDataResult<List<Check>> GetAllCheckId(string id);
        IDataResult<Check> GetById(string id);
        IResult Add (Check check);

    }
}
