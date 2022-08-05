using Businnes.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete
{
    public class FisYonetimi : IFisService
    {
        IFisDal fisDal;

        public FisYonetimi(IFisDal fisDal)
        {
            this.fisDal = fisDal;
        }

        public List<Fis> GetAll()
        {
            
        }
    }
}
