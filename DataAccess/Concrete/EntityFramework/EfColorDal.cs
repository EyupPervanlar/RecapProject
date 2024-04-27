using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(ColorI entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ColorI entity)
        {
            throw new NotImplementedException();
        }

        public ColorI Get(Expression<Func<ColorI, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<ColorI>().SingleOrDefault(filter);
            }
        }

        public List<ColorI> GetAll(Expression<Func<ColorI, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return filter == null ? context.Set<ColorI>().ToList() : context.Set<ColorI>().Where(filter).ToList();
            }
        }

        public void Update(ColorI entity)
        {
            throw new NotImplementedException();
        }
    }
}
