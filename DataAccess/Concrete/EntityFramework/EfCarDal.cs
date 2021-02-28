using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
        public List<CarDto> GetCarDtos()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var details = from c in context.Cars
                              join b in context.Brands on c.BrandId equals b.BrandId
                              join cx in context.Colors on c.ColorId equals cx.ColorId
                              join t in context.TypesOfVehicle on c.TypeOfVehicleId equals t.TypeOfVehicleId
                              select new CarDto
                              {
                                  CarId = c.CarId,
                                  BrandName = b.BrandName,
                                  ColorName = cx.ColorName,
                                  DailyPrice = c.DailyPrice,   
                                  ModelYear = c.ModelYear,
                                  TypeOfVehicleName = t.TypeOfVehicleName,
                                  
                              };
                return details.ToList();
            }
        }
    }
}
