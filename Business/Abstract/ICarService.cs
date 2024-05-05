using Core.Utilities.Result;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {

        IDataResult<List<Car>> getAll();
        IDataResult<List<Car>> getAllCarsBrandId(int id);
        IDataResult<List<Car>> getCarsById(int id);
        IDataResult<List<CarDetailsDto>> getCarDetails();
        IDataResult<Car>GetById(int carId);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);

    }
}
