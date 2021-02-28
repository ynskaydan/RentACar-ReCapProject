using Business.Abstract;
using Core.Aspects.Autofac;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService<User>
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
      //  [ValidationAspect(typeof(UserValidator),Priority=1)]
        public IResult Add(User user)
        {
            if (_userDal.Get(u=> u.UserId == user.UserId) == null)
            {
                if (user.Password.ToString().Length != 6)
                {
                    return new ErrorResult("Password lenght must be 6 character");
                }
                _userDal.Add(user);
                return new SuccessResult("User added successfully");
            }
            return new ErrorResult("User can't be add because this userId taken before.");
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),"All Users got");
        }

        public IDataResult<List<UserDto>> GetAllDetails()
        {
            return new SuccessDataResult<List<UserDto>>(_userDal.GetAllDetails(), "All Details Got");
        }

        public IResult Remove(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult("This user removed completely");
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult("User updated!");

        }

      
    }
}
