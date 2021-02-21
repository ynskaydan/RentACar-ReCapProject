﻿using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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
     

       



        public IResult Add(Color entity)
        {
            if (_colorDal.Get(c => c.ColorId == entity.ColorId) == null)
            {
                if (_colorDal.Get(c => c.ColorName == entity.ColorName) == null)
                {
                    _colorDal.Add(entity);
                    return new SuccessResult("Color is successfully added");

                }
                else
                {
                    return new ErrorResult("You cannot add this Color. Please write a different ColorName");
                }
            }
            else
            {
                return new ErrorResult("You cannot add this Color. Please write a different ColorID");
            }
        }

        public IResult Delete(Color entity)
        {
            _colorDal.Delete(entity);
            return new SuccessResult("Color is completely removed");

        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),"All colors got)");
        }

        public IResult Update(Color entity)
        {
            _colorDal.Update(entity);
            return new SuccessResult("This color is updated");
        }
    }
}
