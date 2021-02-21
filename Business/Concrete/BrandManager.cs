using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }


        public IResult Add(Brand entity)
        {
            if (_brandDal.Get(c => c.BrandId == entity.BrandId) == null)
            {
                if (_brandDal.Get(c => c.BrandName == entity.BrandName) == null)
                {
                    if (_brandDal.Get(c => c.BrandName.Length > 2) != null)
                    {
                        _brandDal.Add(entity);
                        return new SuccessResult("Brand is succesfully added");
                    }
                    else
                    {
                        return new ErrorResult("BrandName must be include at least 2 character");
                    }
                }
                else
                {
                    return new ErrorResult("You cannot add this Brand. Please write a different BrandName");
                }

            }
            else
            {
                return new ErrorResult("You cannot add this Brand. Please write a different BrandID");
            }
        }

        public IResult Delete(Brand entity)
        {
            _brandDal.Delete(entity);
            return new SuccessResult("This brand completely removed.");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), "All brands got");
        }

        public IResult Update(Brand entity)
        {
            _brandDal.Update(entity);
            return new SuccessResult("This brand updated.");
        }
    }
}
