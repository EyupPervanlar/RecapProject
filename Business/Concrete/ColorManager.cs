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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(ColorI color)
        {
         _colorDal.Add(color);
            return new SuccesResult(Messages.ColorAdded);
        }

        public IResult Delete(ColorI color)
        {
            _colorDal.Delete(color);
            return new SuccesResult(Messages.ColorDeleted);
        }

        public IDataResult<List<ColorI>> getAll()
        {
            return new SuccesDataResult<List<ColorI>>(_colorDal.GetAll(), Messages.colorListed); { }
        }

        public IDataResult<ColorI> GetById(int colorid)
        {
            return new SuccesDataResult<ColorI>(_colorDal.Get(c => c.ColorId == colorid), Messages.colorListed);
        }

        public IResult Update(ColorI color)
        {
            _colorDal.Update(color);
            return new SuccesResult(Messages.ColorUpdated);
        }
    }
}
