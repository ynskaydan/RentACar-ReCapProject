using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public void Add(Color entity)
        {

            _colorDal.Add(entity);
        }

        public void Delete(Color entity)
        {
            _colorDal.Delete(entity);
        }


        public Color Get(Expression<Func<Car, bool>> filter)
        {
            return _colorDal.Get();
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public void Update(Color entity)
        {
            _colorDal.Update(entity);
        }
    }
}
