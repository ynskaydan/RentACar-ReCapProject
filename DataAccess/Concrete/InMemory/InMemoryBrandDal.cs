using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;

        public InMemoryBrandDal(List<Brand> brands)
        {
            _brands = brands;
            _brands = new List<Brand>()
            {
             new Brand(){BrandId=1,BrandName="Volkswagen"},
             new Brand(){BrandId=2,BrandName="BMW"},
             new Brand(){BrandId=3,BrandName="Mercedes-Benz"},
             new Brand(){BrandId=4,BrandName="TOGG"},
             new Brand(){BrandId=5,BrandName="Ford"},
             new Brand(){BrandId=6,BrandName="Volvo"},
            };
        }

        public void Add(Brand entity)
        {
            _brands.Add(entity);
        }

        public void Delete(Brand entity)
        {
            Brand brandToDelete = _brands.SingleOrDefault(b => b.BrandId == entity.BrandId);
            _brands.Remove(brandToDelete);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            return _brands.SingleOrDefault();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return _brands.ToList();
        }

 

        public void Update(Brand entity)
        {
            Brand brandToUpdate = _brands.SingleOrDefault(b => b.BrandId == entity.BrandId);
            brandToUpdate.BrandId = entity.BrandId;
            brandToUpdate.BrandName = entity.BrandName;

        }
    }
}
