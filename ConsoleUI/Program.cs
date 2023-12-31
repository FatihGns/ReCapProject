﻿using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            CarTest1();

        }

        private static void CarTest1()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName + "-->" + car.ColorName + "-->" + car.DailyPrice);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { BrandId = 1, ColorId = 2, DailyPrice = 24000, CarName = "Mercedes C Serisi", ModelYear = "2019", ColorName = "Kırmız" });
            carManager.Add(new Car { BrandId = 4, ColorId = 1, DailyPrice = 25000, CarName = "Volvo XC40", ModelYear = "2020", ColorName = "Siyah" });
            carManager.Add(new Car { BrandId = 4, ColorId = 1, DailyPrice = 25000, CarName = "A", ModelYear = "2020", ColorName = "Siyah" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}