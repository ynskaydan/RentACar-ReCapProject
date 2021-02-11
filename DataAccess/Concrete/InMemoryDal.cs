using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryDal : ICarDal
    {
        List<Car> _cars;
        List<Brand> _brands;
        List<Color> _colors;

        public InMemoryDal()
        {      
            _cars = new List<Car>() {
            new Car(){CarId=1,BrandId=1,ColorId=3,ModelYear=2005,DailyPrice=182,Description="Commercial Vehicle" },
            new Car(){CarId=3,BrandId=3,ColorId=2,ModelYear=2021,DailyPrice=300,Description="VIP Vehicle" },
            new Car(){CarId=4,BrandId=1,ColorId=5,ModelYear=2000,DailyPrice=150,Description="Commercial Vehicle" },
            new Car(){CarId=2,BrandId=2,ColorId=2,ModelYear=2005,DailyPrice=200,Description="Indivual Vehicle"},
            new Car(){CarId=5,BrandId=6,ColorId=5,ModelYear=2010,DailyPrice=250,Description="Indivual Vehicle"},
            new Car(){CarId=6,BrandId=4,ColorId=3,ModelYear=2023,DailyPrice=400,Description="Electrical Vehicle"},
            new Car(){CarId=7,BrandId=5,ColorId=6,ModelYear=2009,DailyPrice=150,Description="Commercial Vehicle"},
            new Car(){CarId=8,BrandId=1,ColorId=7,ModelYear=2015,DailyPrice=225,Description="Indivual Vehicle"},


            };

            _brands = new List<Brand>()
            {
             new Brand(){BrandId=1,BrandName="Volkswagen"},
             new Brand(){BrandId=2,BrandName="BMW"},
             new Brand(){BrandId=3,BrandName="Mercedes-Benz"},
             new Brand(){BrandId=4,BrandName="TOGG"},
             new Brand(){BrandId=5,BrandName="Ford"},
             new Brand(){BrandId=6,BrandName="Volvo"},
            };

            _colors = new List<Color>()
            {
             new Color(){ColorId=1,ColorName="Red"},
             new Color(){ColorId=2,ColorName="Black"},
             new Color(){ColorId=3,ColorName="Gray"},
             new Color(){ColorId=4,ColorName="Green"},
             new Color(){ColorId=5,ColorName="White"},
             new Color(){ColorId=6,ColorName="Blue"},
             new Color(){ColorId=7,ColorName="Purple"},

            };

            var cardetails= from car in _cars
                             join b in _brands on car.BrandId equals b.BrandId
                             join c in _colors on car.ColorId equals c.ColorId
                             select new CarDto { CarId = car.CarId, BrandId = car.BrandId, BrandName = b.BrandName, ColorId = car.ColorId, ColorName = c.ColorName, DailyPrice = car.DailyPrice, Description = car.Description, ModelYear = car.ModelYear };




        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }


        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Brand> GetAllBrands()
        {
            return _brands;
        }

        public List<Color> GetAllColors()
        {
            return _colors;
        }

        public IEnumerable<CarDto> GetAllDetails()
        {

            var cardetails = from car in _cars
                             join b in _brands on car.BrandId equals b.BrandId
                             join c in _colors on car.ColorId equals c.ColorId
                             select new CarDto { CarId = car.CarId, BrandId = car.BrandId, BrandName = b.BrandName, ColorId = car.ColorId, ColorName = c.ColorName, DailyPrice = car.DailyPrice, Description = car.Description, ModelYear = car.ModelYear };
            return cardetails;
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return (List<Car>)_cars.Where(c => c.BrandId == brandId);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            car.BrandId = carToUpdate.BrandId;
            car.ColorId = carToUpdate.ColorId;
            car.DailyPrice = carToUpdate.DailyPrice;
            car.Description = carToUpdate.Description;
        }
    }

       
        
    
    }


