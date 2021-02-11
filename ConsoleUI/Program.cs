using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryDal inMemoryDal = new InMemoryDal();
            CarManager carManager = new CarManager(inMemoryDal);
            Car car1 = new Car();
            car1.Description = "Electrical Car";
            car1.CarId = 6;
            car1.ColorId = 3;
            car1.BrandId = 2;
            carManager.Add(car1);
            List<Color> colors = carManager.GetAllColors();



            

            Console.WriteLine("----------------------");

            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.BrandId + " " + c.Description + " " + c.ColorId);
            }
            Console.WriteLine("Our cars listed below: ");
            foreach (var carx in carManager.GetAllDetails())
            {
                Console.WriteLine("------ Car Id:" + carx.CarId + " ------");
                Console.WriteLine("Brand: " + carx.BrandName);
                Console.WriteLine("Color: " + carx.ColorName);
                Console.WriteLine("Car Model Year: " + carx.ModelYear);
                Console.WriteLine("Description: " + carx.Description);
                Console.WriteLine("Daily Price:" + carx.DailyPrice);
            }
            }
        }
    }

