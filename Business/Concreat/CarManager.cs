using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreat.InMemory;
using Entities.Concreat;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreat
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {

            return _carDal.GetAll();
        }
    }
}
