using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class ReceiptManager : IReceiptService
    {
        private IReceiptDal _receiptDal;
        private IReceiptService _receiptService;

        public ReceiptManager(IReceiptDal receiptDal)
        {
            _receiptDal = receiptDal;
        }
        [SecuredOperation("receipt.add,admin")]
        [ValidationAspect(typeof(ReceiptValidator))]
        [CacheRemoveAspect("IReceiptService.Get")]
        public IResult Add(Receipt receipt)
        {
            IResult result = BusinessRules.Run(CheckIfReceiptNoExists(receipt.ReceiptNo));
            if (result != null)
            {
                return result;
            }
            _receiptDal.Add(receipt);
            return new SuccessResult(Messages.ReceiptAdded);

            


            ValidationTool.Validate(new ReceiptValidator(), receipt);
            _receiptDal.Add(receipt);
            return new SuccessResult(Messages.ReceiptAdded);
        }

       [CacheAspect]

        public IDataResult<List<Receipt>> GetAll()
        {
            return new SuccessDataResult<List<Receipt>>(_receiptDal.GetAll());

        }

        //public IDataResult<List<Fis>> GetAll();

        //{
        ////    if (DateTime.Now.Hour==22)
        ////    {
        ////        return new ErrorDataResult<List<Fis>>(Messages.MaintenanceTime);
        ////    }
        ////    return new SuccessDataResult<List<Fis>>(_fisDal.GetAll(),Messages.FisListed);
        ////}

        public IResult Delete(Receipt product)
        {
            _receiptDal.Delete(product);
            return new SuccessResult(Messages.ReceiptDeleted);
        }
        [CacheRemoveAspect("IReceiptService.Get")]
        public IResult Update(Receipt product)
        {

            _receiptDal.Update(product);
            return new SuccessResult(Messages.ReceiptUpdated);
        }
        public IDataResult<List<Receipt>> GetAllReceiptId(string id)
        {
            return new SuccessDataResult<List<Receipt>>( _receiptDal.GetAll(f => f.Id == id));
        }

        [CacheAspect]
        public IDataResult<List<Receipt>> GetByDate(string min, string max)
        {
            return new SuccessDataResult<List<Receipt>>(_receiptDal.GetAll(f => Convert.ToDateTime(f.Date) > Convert.ToDateTime(min) && Convert.ToDateTime(f.Date) < Convert.ToDateTime(max)));
            
        }

        public IDataResult<List<Receipt>> GetByReceiptType(string name)
        {
            return new SuccessDataResult<List<Receipt>>(_receiptDal.GetAll(f => f.ReceiptType == name));
        }
        [CacheAspect]
        public IDataResult<Receipt> GetById(string id)
        {
            return new SuccessDataResult<Receipt> (_receiptDal.Get(f => f.Id == id));
        }

        public IDataResult<List<Receipt>> GetByPerson(string name)
        {
            return new SuccessDataResult<List<Receipt>>(_receiptDal.GetAll(f => f.Person == name));
        }

        public IDataResult<List<ReceiptDetailDto>> GetReceiptDetails()
        {
            return new SuccessDataResult<List<ReceiptDetailDto>>(_receiptDal.GetReceiptDetails());
        }

        private IResult CheckIfReceiptNoExists(string receiptNo)
        {
            var result = _receiptDal.GetAll(f => f.ReceiptNo == receiptNo).Any();
            if (result == true)
            {
                return new ErrorResult(Messages.ReceiptNoAlreadyExists);
            }
            return new SuccessResult();
        }

        public IResult Delete(string id)
        {
            throw new NotImplementedException();
        }
       // [TransactionScopeAspect]
        public IResult AddTransactionalTest(Receipt receipt)
        {
            Add(receipt);
            return null;
        }
    }
}
