using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{   //context:db-class bağlantısı
    public class MasrafDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MasrafDb;Trusted_Connection=true");
        }
        public DbSet<Fis> Fisler { get; set; }
        //public DbSet<Makbuz> Makbuzlar { get; set; }
        //public DbSet<Personel> Personeller { get; set; }
    }
}
