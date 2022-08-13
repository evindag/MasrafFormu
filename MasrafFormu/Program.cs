using Businnes.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
namespace ConsolUI
{

    class Program
    {
        public static IFisDal efFisDal = new EFFisDal();
        public static FisYonetimi fisYonetimi = new FisYonetimi(efFisDal);
        static void Main(string[] args)
        {
            foreach (var fis in efFisDal.GetAll())
            {
                Console.WriteLine(fis.FisId);

            }
            // MakbuzTest();
            FisTest();
        }

        private static void MakbuzTest()
        {
            MakbuzYönetimi makbuzYönetimi = new MakbuzYönetimi(new EFMakbuzDal());
            foreach (var makbuz in makbuzYönetimi.GetAll())
            {
                Console.WriteLine(makbuz.FirmaAdi);
            }
        }

        private static void FisTest()
        {
            
            foreach (var fis in fisYonetimi.GetFisDetails())
            {
                Console.WriteLine(fis.FisId + "/" + fis.Kisi);

            }
        }
    }
}