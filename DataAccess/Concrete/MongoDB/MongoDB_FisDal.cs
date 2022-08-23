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
    public class MongoDB_FisDal : MongoDB_RepositoryBase<Fis, MongoDB_Context<Fis, MongoDB_FisCollection>>, IFisDal
    {
        public List<FisDetailDto> GetFisDetails()
        {
            throw new NotImplementedException();
        }
    }
}
