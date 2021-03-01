using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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
  
        public IDataResult<List<CarDto>> GetCarDtos()
        {
            return new SuccessDataResult<List<CarDto>>(_carDal.GetCarDtos(),"Cars listed with their details");
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandid)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll().Where(c => c.BrandId == brandid).ToList(),"Cars listed by brand id "+brandid);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorid)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll().Where(c => c.ColorId == colorid).ToList(),"Cars listed by color id "+colorid);
        }
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), "All Cars Listed");
        }

        [ValidationAspect(typeof(CarValidator), Priority =1 )]
        public IResult Add(Car entity)
        {
            if (_carDal.Get(c => c.CarId == entity.CarId) == null)
            {
                return new ErrorResult("You can't add");                
            }
            _carDal.Add(entity);
            return new SuccessResult("Succesfully Added!");
        }

        public IResult Update(Car entity)
        {
            _carDal.Update(entity);
            return new SuccessResult("Car Updated!");
        }

        public IResult Delete(Car entity)
        {
            _carDal.Delete(entity);
            return new SuccessResult("Car deleted!");
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == id), "Car got");
        }
    }
}
