using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Fis:IEntity
    {
        public string FisId { get; set; } 
        public int BelgeTarihi { get; set; }
        public int FisNo { get; set; }
        public string Firma { get; set; }
        public double Aciklama { get; set; }
        public string FisTuru { get; set; }
        public double ToplamFis { get; set; }
        public double Kdv { get; set; }
        public string Gorsel { get; set; }
    }
}
