using Core.Utilities.Result;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<ColorI>> getAll();
        IDataResult<ColorI> GetById(int colorid);
        IResult Add(ColorI color);
        IResult Delete(ColorI color);
        IResult Update(ColorI color);
    }
}
