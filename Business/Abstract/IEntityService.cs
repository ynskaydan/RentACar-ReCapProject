using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IEntityService<T>
    {
        List<T> GetAll();

      //  IEnumerable<CarDto> GetAllDetails();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
