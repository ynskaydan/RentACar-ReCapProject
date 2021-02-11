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

        public InMemoryDal()
        {
            
            List<Car> _cars = new List<Car>() {
            new Car(){CarId=1,BrandId=1,ColorId=3,ModelYear=2005,DailyPrice=182,Description="Commercial Vehicle" },
            new Car(){CarId=3,BrandId=1,ColorId=1,ModelYear=2021,DailyPrice=300,Description="VIP Vehicle" },
            new Car(){CarId=4,BrandId=1,ColorId=5,ModelYear=2000,DailyPrice=150,Description="Commercial Vehicle" }
            };
            _cars.Add(new Car() { CarId = 2, BrandId = 1, ColorId = 2, ModelYear = 2010, DailyPrice = 250, Description = "Indivual Vehicle" });
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


