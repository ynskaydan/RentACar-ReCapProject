using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        IEnumerable<CarDto> GetAllDetails();
        List<Car> GetByBrandId(int brandId);
        List<Car> GetAll();
        List<Brand> GetAllBrands();
        List<Color> GetAllColors();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
