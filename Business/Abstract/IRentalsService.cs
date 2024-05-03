using Core.Utilities.Result;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalsService
    {
        IResult Add(Rentals rental);
        IResult Delete(Rentals rental);
        IResult Uptade(Rentals rental);
        IDataResult <Rentals> GetById(int customerId);
        IDataResult<List<Rentals>> GetAll();
    }
}
