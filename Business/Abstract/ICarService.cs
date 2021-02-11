using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Color> GetAllColors();
        List<Brand> GetAllBrands();
        IEnumerable<CarDto> GetAllDetails();
        List<Car> GetByBrandId(int brandId);
        void Add(Car car);

        void Update(Car car);


    }
}
