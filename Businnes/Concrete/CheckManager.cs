using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
        [SecuredOperation("check.add,admin")]
        [ValidationAspect(typeof(CheckValidator))]
        public IResult Add(Check check)
        {
            _checkDal.Add(check);
            return new SuccessResult();
        }

        public IDataResult<List<Check>> GetAll()
        {
            return new SuccessDataResult<List<Check>>(_checkDal.GetAll());
        }
        public IDataResult<List<Check>> GetAllCheckId(string id)
        {
            return new SuccessDataResult<List<Check>>(_checkDal.GetAll(m => m.Id == id));
        }

        public IDataResult<Check> GetById(string id)
        {
            return new SuccessDataResult<Check>(_checkDal.Get(m => m.Id == id));
        }
    }
}
