using Core.DataAccess.Databases.MongoDB;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IReceiptDal:IEntityRepository<Receipt>
    {
        List<ReceiptDetailDto> GetReceiptDetails();
    }
}
