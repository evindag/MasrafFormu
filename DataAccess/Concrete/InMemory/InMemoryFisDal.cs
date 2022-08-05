using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryFisDal : IFisDal
    {
        List<Fis> _fisler;
        public InMemoryFisDal()
        {
            _fisler = new List<Fis>
             {
                 
             };
        }
        public void Add(Fis fis)
        {
            _fisler.Add(fis);
        }

        public void Delete(Fis fis)
        {
            Fis fisToDelete = _fisler.SingleOrDefault(f=>f.FisId == fis.FisId);
            _fisler.Remove(fisToDelete);   
        }

        public List<Fis> GetAll()
        {
            return _fisler;
        }

        public List<Fis> GetAllById(int id)
        {
            return _fisler.Where(f =>f.FisId==id).ToList();
        }

        public void Update(Fis fis)
        {
            Fis fisToUpdate = _fisler.SingleOrDefault(f => f.FisId == fis.FisId);
            fisToUpdate.BelgeTarihi = fis.BelgeTarihi;
            fisToUpdate.FisNo = fis.FisNo;
            fisToUpdate.FisTuru = fis.FisTuru;  
            fisToUpdate.Aciklama = fis.Aciklama;    
            fisToUpdate.Firma = fis.Firma;
            fisToUpdate.Gorsel= fis.Gorsel;
            fisToUpdate.Kdv= fis.Kdv;
            fisToUpdate.ToplamFis= fis.ToplamFis;
            // eren boş yapma
        }
    }
}
