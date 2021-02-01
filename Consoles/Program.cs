using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Consoles
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryCarDal ınMemoryCarDal = new InMemoryCarDal();
            CarManager carManager = new CarManager ( ınMemoryCarDal);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Aracın ismi: "+car.Description);
                Console.WriteLine("Aracın modeli: "+car.CategoryId);
                Console.WriteLine("Aracın rengi: "+car.ColorId);
                Console.WriteLine("Aracın günlük ücreti: "+car.DailyPrice);
                Console.WriteLine("Aracın ıd'si: "+car.Id);
                Console.WriteLine("Aracın model yılı: "+car.ModelYear);
                Console.WriteLine("-------------------------");
            }

            
            ınMemoryCarDal.Delete(new Car { Id = 2, Description = "Araba2", CategoryId = 1, ColorId = 456, DailyPrice = 500, ModelYear = 2012 });

            
            Console.WriteLine("---------Yeni Liste--------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Aracın ismi: " + car.Description);
                Console.WriteLine("Aracın modeli: " + car.CategoryId);
                Console.WriteLine("Aracın rengi: " + car.ColorId);
                Console.WriteLine("Aracın günlük ücreti: " + car.DailyPrice);
                Console.WriteLine("Aracın ıd'si: " + car.Id);
                Console.WriteLine("Aracın model yılı: " + car.ModelYear);
                Console.WriteLine("-------------------------");
            }
        }
    }
}
