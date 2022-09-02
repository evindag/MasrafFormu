


using Core.DataAccess.Databases.MongoDB;
using Core.Entites.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Databases.MongoDB;
using DataAccess.Concrete.MongoDB.Collections;
using System.Collections.Generic;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_OperationClaimsDal : MongoDB_RepositoryBase<OperationClaim, MongoDB_Context<OperationClaim, MongoDB_OperationClaimsCollection>>, IOperationClaimDal
    {
       
    }
}
