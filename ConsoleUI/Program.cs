using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 3, ColorId = 4, ModelYear = 2011, DailyPrice = 645, Descriptions = "Kiralık" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Descriptions + " " + car.DailyPrice);
            }
        }
    }
}
