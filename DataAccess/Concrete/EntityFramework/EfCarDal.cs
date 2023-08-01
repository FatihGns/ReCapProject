using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using Entities.CarDto;

namespace DataAccess.Concrete
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapCarContext context=new ReCapCarContext())
            {
                var result = from c in context.Cars
                             from a in context.Colors
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarName = c.CarName,
                                 ColorName = a.ColorName,
                                 DailyPrice=c.DailyPrice,
                                 BrandName = b.BrandName,
       
                             };
                return result.ToList();
                           
            }
        }
    }
}