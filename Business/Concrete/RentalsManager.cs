using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalsManager : IRentalsService
    {
        IRentalsDal _rentalDal;
        public RentalsManager(IRentalsDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rentals rental)
        {
            Rentals check = _rentalDal.GetRentedCar(rental.CarId);
            if (check == null || check.ReturnDate != null)
            {
                _rentalDal.Add(rental);
                return new SuccesResult(Messages.RentalListed);
            }
            return new ErrorResult(Messages.CarIsNotAvailable);

        }

        public IResult Delete(Rentals rental)
        {
            _rentalDal.Delete(rental);
            return new SuccesResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccesDataResult<List<Rentals>>(_rentalDal.GetAll(), Messages.RentalListed);
        }

        public IDataResult<Rentals> GetById(int customerId)
        {
            return new SuccesDataResult<Rentals>(_rentalDal.Get(r => r.RentalId == customerId));
        }

        public IResult Uptade(Rentals rental)
        {
            _rentalDal.Update(rental);
            return new SuccesResult(Messages.RentalUpdated);
        }
    }
}
