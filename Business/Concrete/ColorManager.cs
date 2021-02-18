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
            if (_colorDal.Get(c => c.ColorId == entity.ColorId) == null)
            {
                if (_colorDal.Get(c => c.ColorName == entity.ColorName) == null)
                {
                    _colorDal.Add(entity);
                }
                else
                {
                    Console.WriteLine("You cannot add this Color. Please write a different ColorName");
                }
            }
            else
            {
                Console.WriteLine("You cannot add this Color. Please write a different ColorID");
            }
        
        }

        public void Delete(Color entity)
        {
            _colorDal.Delete(entity);
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
