using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        
       

        public InMemoryCarDal()
        {      
            _cars = new List<Car>() {
            //new Car(){CarId=1,BrandId=1,ColorId=3,ModelYear=2005,DailyPrice=182,DescriptionId= },
            //new Car(){CarId=3,BrandId=3,ColorId=2,ModelYear=2021,DailyPrice=300,DescriptionId= },
            //new Car(){CarId=4,BrandId=1,ColorId=5,ModelYear=2000,DailyPrice=150,DescriptionId= },
            //new Car(){CarId=2,BrandId=2,ColorId=2,ModelYear=2005,DailyPrice=200,DescriptionId="Indivual Vehicle"},
            //new Car(){CarId=5,BrandId=6,ColorId=5,ModelYear=2010,DailyPrice=250,DescriptionId="Indivual Vehicle"},
            //new Car(){CarId=6,BrandId=4,ColorId=3,ModelYear=2023,DailyPrice=400,DescriptionId="Electrical Vehicle"},
            //new Car(){CarId=7,BrandId=5,ColorId=6,ModelYear=2009,DailyPrice=150,DescriptionId="Commercial Vehicle"},
            //new Car(){CarId=8,BrandId=1,ColorId=7,ModelYear=2015,DailyPrice=225,DescriptionId="Indivual Vehicle"},
            };

            //var cardetails= from car in _cars
            //                 join b in _brands on car.BrandId equals b.BrandId
            //                 join c in _colors on car.ColorId equals c.ColorId
            //                 select new CarDto { CarId = car.CarId, BrandId = car.BrandId, BrandName = b.BrandName, ColorId = car.ColorId, ColorName = c.ColorName, DailyPrice = car.DailyPrice, Description = car.Description, ModelYear = car.ModelYear };
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

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return _cars.SingleOrDefault();
        }

   

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars.ToList();
                
        }

        public List<CarDto> GetCarDtos()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            car.BrandId = carToUpdate.BrandId;
            car.ColorId = carToUpdate.ColorId;
            car.DailyPrice = carToUpdate.DailyPrice;
            car.TypeOfVehicleId = carToUpdate.TypeOfVehicleId;
        }                  
    }
}


