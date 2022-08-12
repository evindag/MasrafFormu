using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFMakbuzDal : EFEntityRepositoryBase<Fis, NorthwindContext>, IMakbuzDal
    {
        public void Add(Fis entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Fis entity)
        {
            throw new NotImplementedException();
        }

        public Fis Get()
        {
            throw new NotImplementedException();
        }

        public List<Fis> GetAll(Expression<Func<Fis, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Fis> GetAllById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Fis entity)
        {
            throw new NotImplementedException();
        }
    }
}
