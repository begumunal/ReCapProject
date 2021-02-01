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
                new Car{ Id=1, Description="Araba1", CategoryId=1, ColorId=123, DailyPrice=200, ModelYear=2010 },
                new Car{ Id=2, Description="Araba2", CategoryId=1, ColorId=456, DailyPrice=500, ModelYear=2012 },
                new Car{ Id=3, Description="Araba3", CategoryId=2, ColorId=456, DailyPrice=300, ModelYear=2014 },
                new Car{ Id=4, Description="Araba4", CategoryId=2, ColorId=123, DailyPrice=600, ModelYear=2015 },
                new Car{ Id=5, Description="Araba5", CategoryId=3, ColorId=789, DailyPrice=400, ModelYear=2019 },

            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int categoryId)
        {
            return _cars.Where(c => c.CategoryId == categoryId).ToList();
        }

        public void Update(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CategoryId == car.CategoryId);
            carToDelete.CategoryId = car.CategoryId;
            carToDelete.ColorId = car.ColorId;
            carToDelete.DailyPrice = car.DailyPrice;
            carToDelete.Description = car.Description;
            carToDelete.Id = car.Id;
            carToDelete.ModelYear = car.ModelYear;
        }
    }
}
