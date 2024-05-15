using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac;
using Core.Utilities.Result;
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
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            if (car.CarName.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccesResult(Messages.CarAdded);
            }
            else
            {
                Console.WriteLine("Hata!!!!!!!!!!!!!!");
                return new ErrorResult(Messages.CarNameInvalid);
            }

        }
        
        public IResult Delete(Car car)
        {
           _carDal.Delete(car);
            return new SuccesResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> getAll()
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }

            return new SuccesDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<Car>> getAllCarsBrandId(int id)
        {
            return new SuccesDataResult<List<Car>>( _carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccesDataResult<Car>(_carDal.Get(c=>c.CarId==carId));
        }

        public IDataResult<List<CarDetailsDto>> getCarDetails()
        {
            return new SuccesDataResult<List<CarDetailsDto>>( _carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> getCarsById(int id)
        {
            return new SuccesDataResult<List<Car>>( _carDal.GetAll(c => c.CarId == id));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccesResult(Messages.CarUpdated);
        }
    }
}
