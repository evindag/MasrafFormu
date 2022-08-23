using Businnes.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Businnes.Concrete
{
    public class MakbuzYonetimi : IMakbuzService
    {
        IMakbuzDal _makbuzDal;
        public MakbuzYonetimi(IMakbuzDal makbuzDal)
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
