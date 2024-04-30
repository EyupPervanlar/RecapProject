using Business.Abstract;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Cars is Added");
            }
            else
            {
                Console.WriteLine("Hata!!!!!!!!!!!!!!");
            }

        }

        public List<Car> getAll()
        {

            return _carDal.GetAll();
        }

        public List<Car> getAllCarsBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<CarDetailsDto> getCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> getCarsById(int id)
        {
            return _carDal.GetAll(c => c.CarId == id);
        }
    }
}
