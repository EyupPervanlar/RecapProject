using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car { Id = 1,BrandId = 1,ColorId=1,DailyPrice=800,Description="Kiralama",ModelYear="2012"},
                new Car { Id = 2,BrandId = 2,ColorId=2,DailyPrice=600,Description="Kiralama2",ModelYear="2022"},
                new Car { Id = 3,BrandId = 3,ColorId=3,DailyPrice=500,Description="Kiralama3",ModelYear="2002"},
                new Car { Id = 4,BrandId = 4,ColorId=4,DailyPrice=400,Description="Kiralama4",ModelYear="2020"},
                new Car { Id = 5,BrandId = 5,ColorId=5,DailyPrice=560,Description="Kiralama5",ModelYear="2018"},

                };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }
        public void Delete(Car car)
        {
            _cars.Remove(car);
        }

        public List<Car> getAll()
        {
            //simüle
            return getAll();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.CarName = car.CarName;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }


    }
}
