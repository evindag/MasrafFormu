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
    public class MongoDB_MakbuzDal : MongoDB_RepositoryBase<Makbuz, MongoDB_Context<Makbuz, MongoDB_MakbuzCollection>>, IMakbuzDal
    {
    }
}
