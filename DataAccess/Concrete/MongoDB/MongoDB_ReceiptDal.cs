using Core.DataAccess.Databases.MongoDB;
using DataAccess.Abstract;
using DataAccess.Concrete.Databases.MongoDB;
using DataAccess.Concrete.MongoDB.Collections;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_ReceiptDal : MongoDB_RepositoryBase<Receipt, MongoDB_Context<Receipt, MongoDB_ReceiptCollection>>, IReceiptDal
    {
        public List<ReceiptDetailDto> GetReceiptDetails()
        {
            throw new NotImplementedException();
        }
    }
}
