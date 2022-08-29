using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
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
        IReceiptDal _receiptDal;

        public ReceiptManager(IReceiptDal receiptDal)
        {
            _receiptDal = receiptDal;
        }
        [ValidationAspect(typeof(ReceiptValidator))]
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

        public IDataResult<List<Receipt>> GetAllReceiptId(string id)
        {
            return new SuccessDataResult<List<Receipt>>( _receiptDal.GetAll(f => f.Id == id));
        }


        public IDataResult<List<Receipt>> GetByDate(string min, string max)
        {
            return new SuccessDataResult<List<Receipt>>(_receiptDal.GetAll(f => Convert.ToDateTime(f.Date) > Convert.ToDateTime(min) && Convert.ToDateTime(f.Date) < Convert.ToDateTime(max)));
            
        }

        public IDataResult<List<Receipt>> GetByReceiptType(string name)
        {
            return new SuccessDataResult<List<Receipt>>(_receiptDal.GetAll(f => f.ReceiptType == name));
        }

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
        

    }
}
