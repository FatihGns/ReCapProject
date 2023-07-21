using Business.Concrete;
using DataAccess.Concrete.EntityMemory;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("-----------------FATİH OTOMOTİV--------------");
            Console.WriteLine('\n');
            CarManager carManager = new CarManager(new InCarMemoryDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine( ' '+ car.CarName+ ' '+ car.Description +' '+ car.ColorName +' '+car.DailyPrice);
            }
            Console.ReadLine();
            
                
        }
    }
}
