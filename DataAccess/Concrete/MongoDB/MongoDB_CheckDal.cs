using Core.DataAccess.Databases.MongoDB;
using DataAccess.Abstract;
using DataAccess.Concrete.Databases.MongoDB;
using DataAccess.Concrete.MongoDB.Collections;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_CheckDal : MongoDB_RepositoryBase<Check, MongoDB_Context<Check, MongoDB_CheckCollection>>, ICheckDal
    {
    }
}
