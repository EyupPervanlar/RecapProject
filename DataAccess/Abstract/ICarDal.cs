using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> getAll();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetById(int carId);
    }
}
