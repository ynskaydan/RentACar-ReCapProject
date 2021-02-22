using Core.Utilities.Results.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService<T>
    {
        IResult Add(T User);
        IResult Remove(T user);
        IResult Update(T user);
        IDataResult<List<T>> GetAll();
        IDataResult<List<UserDto>> GetAllDetails();
    }
}
