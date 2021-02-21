using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2016, DailyPrice = 650, Description = "Kiralık"},
                new Car{Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2012, DailyPrice = 250, Description = "Kirada"},
                new Car{Id = 3, BrandId = 3, ColorId = 4, ModelYear = 2013, DailyPrice = 340, Description = "Kiralık"},
                new Car{Id = 4, BrandId = 4, ColorId = 3, ModelYear = 2015, DailyPrice = 500, Description = "Kiralık"},
                new Car{Id = 5, BrandId = 2, ColorId = 1, ModelYear = 2020, DailyPrice = 1000, Description = "Kirada"}
            };
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

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
