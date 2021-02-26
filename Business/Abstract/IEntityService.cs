using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IEntityService<T>
    {
        IDataResult<List<T>> GetAll();

      //  IEnumerable<CarDto> GetAllDetails();
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);
        IDataResult<T> GetById(int id);
    }
}
