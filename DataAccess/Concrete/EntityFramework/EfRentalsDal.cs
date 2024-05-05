using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalsDal : EfEntityRepositoryBase<Rentals, RentACarContext>, IRentalsDal
    {
        public Rentals GetRentedCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
