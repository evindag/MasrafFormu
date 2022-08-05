using Businnes.Concrete;
using DataAccess.Concrete.InMemory;
using System;
namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)
        {
            FisYonetimi fisYonetimi = new FisYonetimi(new InMemoryFisDal());
            foreach (var fis in fisYonetimi.GetAll())
            {
                Console.WriteLine(fis.FisId);
            }
        }
    }
}