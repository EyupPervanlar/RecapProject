using Core.Utilities.Result;
using Entites.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImagesService
    {
        IDataResult<List<CarImages>> GetAll();
       IDataResult<CarImages> GetCarImagesById(int id);
        IResult Add(IFormFile file, CarImages carImage);
        IResult Delete(CarImages carImage);
        IResult Update(IFormFile file, CarImages carImage);
    }
}
