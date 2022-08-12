using Businnes.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // FisTest();
            MakbuzYönetimi makbuzYönetimi = new MakbuzYönetimi(new EFMakbuzDal());
            foreach (var makbuz in makbuzYönetimi.GetAll())
            {
                Console.WriteLine(makbuz.FirmaAdi);
            }
        }

        private static void FisTest()
        {
            FisYonetimi fisYonetimi = new FisYonetimi(new EFFisDal());
            foreach (var fis in fisYonetimi.GetAll())
            {
                Console.WriteLine(fis.FisId);

            }
        }
    }
}