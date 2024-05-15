using Business.Abstract;
using Business.Constans;
using Core.Utilities.Business;
using Core.Utilities.FileHelper;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImagesManager : ICarImagesService
    {
        ICarImagesDal _carImageDal;
        IFileHelper _fileHelper;
        public CarImagesManager(ICarImagesDal carImagesDal, IFileHelper fileHelper)
        {
            _carImageDal = carImagesDal;
            _fileHelper = fileHelper;
        }
        public IResult Add(IFormFile file, CarImages carImage)
        {
            IResult result = BusinessRules.Run(CheckCarImageLimit(carImage.CarId));
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = _fileHelper.Upload(file,PathConstans.ImagesPath);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccesResult("Resim Başarıyla Yüklendi");
        }
        public IResult Update(IFormFile file, CarImages carImage)
        {
            carImage.ImagePath = _fileHelper.Update(file, PathConstans.ImagesPath + carImage.ImagePath, PathConstans.ImagesPath);
        _carImageDal.Update(carImage);
            return new SuccesResult();
        }
        public IResult Delete(CarImages carImage)
        {
           _fileHelper.Delete(PathConstans.ImagesPath + carImage.ImagePath);
            _carImageDal.Update(carImage);
            return new SuccesResult();
        }

        public IDataResult<List<CarImages>> GetAll()
        {
            return new SuccesDataResult<List<CarImages>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImages> GetCarImagesById(int id)
        {
            return new SuccesDataResult<CarImages>(_carImageDal.Get(c => c.CarImagesId == id));
        }
        private IDataResult<List<CarImages>>GetDefaultImage(int carId)
        {
            List<CarImages>carImage=new List<CarImages> ();
            carImage.Add(new CarImages { CarId = carId, Date = DateTime.Now, ImagePath = "DefaultImage.jpg" });
            return new SuccesDataResult<List<CarImages>> (carImage);
        }
        private IResult CheckCarImageLimit(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (result > 0)
            {
                return new SuccesResult();
            }
            return new ErrorResult();
        }

    }
}
