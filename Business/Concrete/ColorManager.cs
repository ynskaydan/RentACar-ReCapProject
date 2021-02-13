﻿using Business.Abstract;
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

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            return _colorDal.Get(filter);
        }

    

        public List<Color> GetAll(Expression<Func<Color, bool>> filter=null)
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Color entity)
        {
            _colorDal.Update(entity);
        }
    }
}
