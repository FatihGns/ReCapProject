using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InCarMemoryDal : ICarDal
    {
        List<Car> _cars;

        public InCarMemoryDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,CarName="Mercedes-Benz",Description="CLA",ModelYear="2020",ColorName="Siyah",DailyPrice=5000},
                new Car{CarId=2,BrandId=1,ColorId=2,CarName="Mercedes-Benz",Description="S63",ModelYear="2023",ColorName="Kırmızı",DailyPrice=10000},
                new Car{CarId=3,BrandId=2,ColorId=1,CarName="BMW",Description="İ8",ModelYear="2022",ColorName="Siyah",DailyPrice=7000},
                new Car{CarId=4,BrandId=2,ColorId=2,CarName="BMW",Description="320",ModelYear="2023",ColorName="Kırmız",DailyPrice=8000},
                new Car{CarId=5,BrandId=3,ColorId=3,CarName="AUDİ",Description="A5",ModelYear="2019",ColorName="Mavi",DailyPrice=5000}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarOfDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(CarOfDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car CarOfUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            CarOfUpdate.CarId = car.CarId;
            CarOfUpdate.BrandId = car.BrandId;
            CarOfUpdate.ColorId = car.ColorId;

            CarOfUpdate.CarName = car.CarName;
            CarOfUpdate.ColorName = car.ColorName;

            CarOfUpdate.DailyPrice = car.DailyPrice;
            car.Description = car.Description;   
        }
    }
}
