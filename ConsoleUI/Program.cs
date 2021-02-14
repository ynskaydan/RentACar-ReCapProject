﻿using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
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
          
            CarManager carManager = new CarManager(new EfCarDal());
         
           
            //List<Color> colors = carManager.GetAllColors();

            foreach (var carxbrand in carManager.GetCarsByBrandId(5))
            {
                Console.WriteLine( carxbrand.CarId + " " + carxbrand.Description + " Filtered by Brand  " + carxbrand.BrandId );
            }

            foreach(var carxcolor in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(carxcolor.CarId + " " + carxcolor.Description + " Filtered by Color  "+ carxcolor.ColorId);
            }

            Console.WriteLine("----------------------");

            foreach (Car c in carManager.GetAll())
            {
                Console.WriteLine(c.BrandId + " " + c.Description + " " + c.ColorId);
            }
            Console.WriteLine("Our cars listed below: ");
            //foreach (var carx in carManager.GetAllDetails())
            //{
            //    Console.WriteLine("------ Car Id:" + carx.CarId + " ------");
            //    Console.WriteLine("Brand: " + carx.BrandName);
            //    Console.WriteLine("Color: " + carx.ColorName);
            //    Console.WriteLine("Car Model Year: " + carx.ModelYear);
            //    Console.WriteLine("Description: " + carx.Description);
            //    Console.WriteLine("Daily Price:" + carx.DailyPrice);
            //}
            }
        }
    }

