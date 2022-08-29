using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CheckManager : ICheckService
    {
        ICheckDal _checkDal;
        public CheckManager(ICheckDal checkDal)
        {
            _checkDal = checkDal;
        }

        public IResult Add(Check check)
        {
            _checkDal.Add(check);
            return new SuccessResult();
        }

        public IDataResult<List<Check>> GetAll()
        {
            return new SuccessDataResult<List<Check>>(_checkDal.GetAll());
        }

        public IDataResult<Check> GetById(string id)
        {
            return new SuccessDataResult<Check>(_checkDal.Get(m => m.Id == id));
        }
    }
}
