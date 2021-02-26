using DataAccess.Abstract;
using Entities.Concreat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concreat.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{CarId=1,BrandId =1 ,ColorId=1,DailyPrice=152500,ModelYDailyPriceear=125000,ModelYear="2015"},
            new Car{CarId=2,BrandId =2 ,ColorId=1,DailyPrice=14000,ModelYDailyPriceear=125000,ModelYear="2012"},
            new Car{CarId=3,BrandId =2 ,ColorId=3,DailyPrice=35000,ModelYDailyPriceear=12000,ModelYear="1995"},
            new Car{CarId=4,BrandId =3 ,ColorId=2,DailyPrice=180000,ModelYDailyPriceear=175000,ModelYear="2018"},
            new Car{CarId=5,BrandId =4 ,ColorId=3,DailyPrice=11000,ModelYDailyPriceear=100000,ModelYear="2010"},
            new Car{CarId=6,BrandId =3 ,ColorId=2,DailyPrice=92000,ModelYDailyPriceear=85000,ModelYear="2008"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete=null;
            CarToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(CarToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(Car car)
        {
            return _cars.Where(c => c.CarId == car.CarId).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.ModelYDailyPriceear = car.ModelYDailyPriceear;

        }
    }
}
