using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFFisDal : EFEntityRepositoryBase<Fis, MasrafDbContext>, IFisDal
    {
        public List<FisDetailDto> GetFisDetails()
        {
            using (MasrafDbContext context = new MasrafDbContext())
            {
                var result = from f in context.Fisler
                             //join m in context.Makbuzlar
                             //on f.FisId equals f.FisId
                             select new FisDetailDto {FisId = f.FisId, 
                                 Firma = f.Firma, Aciklama  = f.Aciklama,
                                 BelgeTarihi = f.BelgeTarihi, FisNo =f.FisNo,
                                  FisTuru = f.FisTuru, Gorsel = f.Gorsel,
                                   Kdv = f.Kdv, Kisi= f.Kisi, ToplamFis= f.ToplamFis
                              

                             };
                return result.ToList();
            }
        }
    }
}
