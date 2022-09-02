using Core.DataAccess.Databases.MongoDB;
using Core.Entites.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Databases.MongoDB;
using DataAccess.Concrete.MongoDB.Collections;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MongoDB.Driver;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_UserDal : MongoDB_RepositoryBase<User, MongoDB_Context<User, MongoDB_UserCollection>>, IUserDal
    {
        public List<User> GetAllById(int id)
        {
            throw new NotImplementedException();
        }

        public List<OperationClaim> GetClaims(string userId)
        {

            User _user = new User();
            List<UserOperationClaim> _userOperationClaims = new List<UserOperationClaim>();
            List<OperationClaim> _claims = new List<OperationClaim>();

            using (var context = new MongoDB_Context<User, MongoDB_UserCollection>())
            {
                _user = context.collection.Find(r => r.Id == userId).First();
            }
            using (var context = new MongoDB_Context<UserOperationClaim, MongoDB_UserOperationClaimsCollection>())
            {
                _userOperationClaims = context.collection.Find(r => r.UserId == userId).ToList();
            }
            using (var context = new MongoDB_Context<OperationClaim, MongoDB_OperationClaimsCollection>())
            {
                foreach (var userOperationClaim in _userOperationClaims)
                {
                    _claims.Add(context.collection.Find(r => r.Id == userOperationClaim.OperationClaimId).First());
                }
            }
            return _claims;



        }


        void Core.DataAccess.IEntityRepository<User>.Delete(User entity)
        {
            throw new NotImplementedException();
        }

        void Core.DataAccess.IEntityRepository<User>.Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
