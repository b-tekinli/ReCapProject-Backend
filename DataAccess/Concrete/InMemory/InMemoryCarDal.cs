using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Brand> _brands;
        List<Car> _cars;
        List<Color> _colors;

        public InMemoryCarDal()
        {
            _brands = new List<Brand>
            {
                new Brand{BrandId = 5, BrandName = "Renault"},
                new Brand{BrandId = 6, BrandName = "Mercedes"},
                new Brand{BrandId = 7, BrandName = "Audi"},
                new Brand{BrandId = 8, BrandName = "BMW"},
                new Brand{BrandId = 9, BrandName = "Hyundai"}
            };

            _cars = new List<Car>
            {
                new Car{CarId = 6, BrandId = 1, ColorId = 1, ModelYear = 2016, DailyPrice = 650, Descriptions = "Kiralık"},
                new Car{CarId = 7, BrandId = 2, ColorId = 2, ModelYear = 2012, DailyPrice = 250, Descriptions = "Kirada"},
                new Car{CarId = 8, BrandId = 3, ColorId = 4, ModelYear = 2013, DailyPrice = 340, Descriptions = "Kiralık"},
                new Car{CarId = 9, BrandId = 4, ColorId = 3, ModelYear = 2015, DailyPrice = 500, Descriptions = "Kiralık"},
                new Car{CarId = 10, BrandId = 2, ColorId = 1, ModelYear = 2020, DailyPrice = 1000, Descriptions = "Kirada"}
            };

            _colors = new List<Color>
            {
                new Color{ColorId = 5, ColorName = "Black"},
                new Color{ColorId = 6, ColorName = "White"},
                new Color{ColorId = 7, ColorName = "Red"},
                new Color{ColorId = 8, ColorName = "Purple"},
                new Color{ColorId = 9, ColorName = "Brown"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Yeni araba bilgileri sisteme eklendi. Araba şu anda: {0}", car.Descriptions);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
            Console.WriteLine("Araba sistemden silindi.");
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Descriptions = car.Descriptions;
            Console.WriteLine("Sistemde araba bilgileri güncellendi.");
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
