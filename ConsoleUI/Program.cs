using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            //CarManager carManager = new CarManager(inMemoryCarDal)
            //ColorManager colorManager1 = new ColorManager(new InMemoryColorDal());
            //BrandManager brandManager1 = new BrandManager(new InMemoryBrandDal());

            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            TypeOfVehicleManager typesManager = new TypeOfVehicleManager(new EfTypeOfVehicleDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            brandManager.Add(new Brand { BrandId = 11, BrandName = "Anadol" });
            colorManager.Add(new Color { ColorId = 9, ColorName = "Turquaz" });
            carManager.Add(new Car { BrandId = 11, ColorId = 9, CarId = 22, ModelYear = 1994, DailyPrice = 50,Description="Nostalgic" });
            Console.WriteLine(rentalManager.Add(new Rental()
            {
                CarId = 4,
                RentalId = 4,
                CustomerId = 5,

            }).Success);




            foreach (var rent in rentalManager.GetAll().Data)
            {
                Console.WriteLine("Rent Id: " + rent.RentalId);
                Console.WriteLine("car id "+ rent.CarId);
            }

            //Console.WriteLine("Mercedes-Benz Cars: ");
            //foreach (var carxbrand in carManager.GetCarsByBrandId(2))
            //{
            //    Console.WriteLine( carxbrand.CarId + " " + carxbrand.Description + " Filtered by Brand  " + carxbrand.BrandId );
            //}
            //Console.WriteLine("Black Cars: ");
            //foreach(var carxcolor in carManager.GetCarsByColorId(3))
            //{
            //    Console.WriteLine(carxcolor.CarId + " " + carxcolor.Description + " Filtered by Color  "+ carxcolor.ColorId);
            //}


            Console.WriteLine(userManager.GetAllDetails().Message);
            var resultusers = userManager.GetAllDetails().Data;
            if (userManager.GetAllDetails().Success == true)
            {

                foreach (var user in resultusers)
                {
                    Console.WriteLine("--- " + user.UserId + "---");
                    Console.WriteLine("User Name: " + user.Name);
                    Console.WriteLine("User SurName: " + user.Surname);
                    Console.WriteLine("User Email: " + user.Email);
                    Console.WriteLine("User's CompanyName : " + user.CompanyName);
                }
            }
            Console.WriteLine("----------------------");
       
            

            Console.WriteLine(carManager.GetCarDtos().Message);

            foreach (var car in carManager.GetCarDtos().Data)
            {
                Console.WriteLine("----" + car.CarId + "----");
                Console.WriteLine("Brand Name: " + car.BrandName);
                Console.WriteLine("Type: " + car.TypeOfVehicleName);
                Console.WriteLine("Color: " + car.ColorName);
                Console.WriteLine("Model Year: " + car.ModelYear);
                Console.WriteLine("Description: " + car.Description);
                Console.WriteLine("Daily Price: " + car.DailyPrice);
            }
        }
        }
    }

