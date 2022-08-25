using Businnes.Abstract;
using Businnes.Constants;
using Businnes.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace Businnes.Concrete
{
    public class FisYonetimi : IFisService
    {
        IFisDal _fisDal;

        public FisYonetimi(IFisDal fisDal)
        {
            _fisDal = fisDal;
        }
        [ValidationAspect(typeof(FisValidator))]
        public IResult Add(Fis fis)
        {
            ValidationTool.Validate(new FisValidator(), fis);
            _fisDal.Add(fis);
            return new SuccessResult(Messages.FisAdded);
        }

       

        public IDataResult<List<Fis>> GetAll()
        {
            throw new NotImplementedException();
        }

        //public IDataResult<List<Fis>> GetAll();

        //{
        ////    if (DateTime.Now.Hour==22)
        ////    {
        ////        return new ErrorDataResult<List<Fis>>(Messages.MaintenanceTime);
        ////    }
        ////    return new SuccessDataResult<List<Fis>>(_fisDal.GetAll(),Messages.FisListed);
        ////}

        public IDataResult<List<Fis>> GetAllFisId(int id)
        {
            return new SuccessDataResult<List<Fis>>( _fisDal.GetAll(f => f.FisId == id));
        }


        public IDataResult<List<Fis>> GetByBelgeTarihi(string min, string max)
        {
            return new SuccessDataResult<List<Fis>>(_fisDal.GetAll(f => Convert.ToDateTime(f.BelgeTarihi) > Convert.ToDateTime(min) && Convert.ToDateTime(f.BelgeTarihi) < Convert.ToDateTime(max)));
            
        }

        public IDataResult<List<Fis>> GetByFisTuru(string name)
        {
            return new SuccessDataResult<List<Fis>>(_fisDal.GetAll(f => f.FisTuru == name));
        }

        public IDataResult<Fis> GetById(int id)
        {
            return new SuccessDataResult<Fis> (_fisDal.Get(f => f.FisId == id));
        }

        public IDataResult<List<Fis>> GetByKisi(string name)
        {
            return new SuccessDataResult<List<Fis>>(_fisDal.GetAll(f => f.Kisi == name));
        }

        public IDataResult<List<FisDetailDto>> GetFisDetails()
        {
            return new SuccessDataResult<List<FisDetailDto>>(_fisDal.GetFisDetails());
        }
    }
}
