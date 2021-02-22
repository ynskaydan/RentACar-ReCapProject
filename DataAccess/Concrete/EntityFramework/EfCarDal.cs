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
                              join t in context.Types on c.TypeId equals t.TypesId
                              select new CarDto
                              {
                                  CarId = c.CarId,
                                  BrandId = c.BrandId,
                                  BrandName = b.BrandName,
                                  ColorId = c.ColorId,
                                  ColorName = cx.ColorName,
                                  DailyPrice = c.DailyPrice,
                                  Description = c.Description,
                                  ModelYear = c.ModelYear,
                                  TypeName = t.TypesName
                              };
                return details.ToList();
            }
        }
    }
}
