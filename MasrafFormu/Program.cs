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
            FisYonetimi fisYonetimi = new FisYonetimi(new EFFisDal());
            foreach (var fis in fisYonetimi.GetAll())
            //foreach (var fis in fisYonetimi.GetAllByFisId(2))
            //foreach (var fis in fisYonetimi.GetAllByFisId(2,5))
            {
                Console.WriteLine(fis.FisId);
                //Console.WriteLine(fis.FisTuru);
                //Console.WriteLine(fis.BelgeTarihi);
            }
        }
    }
}