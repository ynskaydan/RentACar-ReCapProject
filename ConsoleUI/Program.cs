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
            var x = carManager.GetAll();
            foreach (var c in x)
            {
                Console.WriteLine(c.DailyPrice);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
