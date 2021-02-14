using Business.Abstract;
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

        public void Add(Brand entity)
        {
            if (_brandDal.Get(c=> c.BrandName.Length>2) != null)
            {
                _brandDal.Add(entity);
            }
            else
            {
                Console.WriteLine("BrandName must be include at least 2 character ");
            }
            
        }

        public void Delete(Brand entity)
        {
            _brandDal.Delete(entity);
        }


        public Brand Get(Expression<Func<Car, bool>> filter)
        {
            return _brandDal.Get(filter);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public void Update(Brand entity)
        {
            _brandDal.Update(entity);
        }
    }
}
