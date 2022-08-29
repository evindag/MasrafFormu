using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IReceiptService
    {
        IDataResult<List<Receipt>> GetAll();
        IDataResult<List<Receipt>> GetAllReceiptId(string id);
        IDataResult<List<Receipt>> GetByDate(string min,string max);
        IDataResult<List<Receipt>> GetByReceiptType(string name);
        IDataResult<List<Receipt>> GetByPerson(string name);
        IDataResult<Receipt> GetById(string id);
        IResult Add(Receipt receipt);

        IDataResult<List<ReceiptDetailDto>> GetReceiptDetails();
    }
}
