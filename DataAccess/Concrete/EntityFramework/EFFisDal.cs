using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFFisDal : IFisDal
    {
        public void Add(Fis entity)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();  

            }
        }

        public void Delete(Fis entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public Fis Get(Expression<Func<Fis, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Fis>().SingleOrDefault(filter);
            }
        }

        public Fis Get()
        {
            throw new NotImplementedException();
        }

        public List<Fis> GetAll(Expression<Func<Fis, bool>> filter = null)
        {
            using (NorthwindContext context =new NorthwindContext())
            {
                return filter == null ? context.Set<Fis>().ToList()
                    :context.Set<Fis>().Where(filter).ToList();
                    //Select*From Fis
            }
        }

        public List<Fis> GetAllById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Fis entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
