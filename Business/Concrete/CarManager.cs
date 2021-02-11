using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
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
            _carDal.Add(car);
        }

      
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Brand> GetAllBrands()
        {
            return _carDal.GetAllBrands();
        }

        public List<Color> GetAllColors()
        {
            return _carDal.GetAllColors();
        }

        public IEnumerable<CarDto> GetAllDetails()
        {
            return _carDal.GetAllDetails();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
