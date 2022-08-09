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
    public class EFMakbuzDal : IMakbuzDal
    {
        public void Add(Makbuz entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Makbuz entity)
        {
            throw new NotImplementedException();
        }

        public Makbuz Get()
        {
            throw new NotImplementedException();
        }

        public List<Makbuz> GetAll(Expression<Func<Makbuz, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Makbuz> GetAllById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Makbuz entity)
        {
            throw new NotImplementedException();
        }
    }
}
