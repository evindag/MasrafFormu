using Businnes.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete
{
    public class MakbuzYönetimi : IMakbuzService
    {
        IMakbuzDal _makbuzDal;
        public MakbuzYönetimi(IMakbuzDal makbuzDal)
        {
            _makbuzDal = makbuzDal;
        }
    
        public List<Makbuz> GetAll()
        {
            return _makbuzDal.GetAll();
        }

        public Makbuz GetById(int makbuzId)
        {
            return _makbuzDal.Get(m => m.MakbuzId == makbuzId);
        }
    }
}
