using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Makbuz:IEntity
    {
        public int MakbuzId { get; set; }
        public int Tarih { get; set; }
        public double MakbuzTutari { get; set; }
        public string MakbuzAciklamasi { get; set; }
        public string MakbuzGorseli { get; set; }
        public string FirmaAdi { get; set; }

        public string YetkiliAd { get; set; }
        public string Adres { get; set; }

    }
}
