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
         void Add(Car car);
       List<Car> getAll();
        List<Car> getAllCarsBrandId(int id);
        List<Car> getCarsById(int id);
        List<CarDetailsDto> getCarDetails();
        
      
    }
}
