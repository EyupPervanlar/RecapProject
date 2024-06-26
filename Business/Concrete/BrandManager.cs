﻿using Business.Abstract;
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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccesResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccesResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccesDataResult<List<Brand>>(_brandDal.GetAll(), "Brands Are listed");
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return new SuccesDataResult<Brand>(_brandDal.Get(b => b.BrandId == brandId), Messages.Brandlisted);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccesResult(Messages.BrandUpdated);
        }
    }
}
