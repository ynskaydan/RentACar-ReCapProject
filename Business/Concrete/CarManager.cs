using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
         
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (_carDal.Get(c=> c.DailyPrice>0) != null)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("You cannot add car which is free");
            }

        }

        public void Delete(Car entity)
        {
            _carDal.Delete(entity);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandid)
        {
            return _carDal.GetAll().Where(c => c.BrandId == brandid).ToList();
        }

        public List<Car> GetCarsByColorId(int colorid)
        {
            return _carDal.GetAll().Where(c => c.ColorId == colorid).ToList();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
