using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer user)
        {
            if (_customerDal.Get(c => c.CustomerId == user.CustomerId) == null)
            {
                
                _customerDal.Add(user);
                return new SuccessResult("Customer added successfully");
            }
            return new ErrorResult("Customer can't be add because this CustomerId taken before.");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), "All customers got");
        }

        public IDataResult<List<UserDto>> GetAllDetails()
        {
            throw new NotImplementedException();
        }

        public IResult Remove(Customer user)
        {
            _customerDal.Delete(user);
            return new SuccessResult("This customer removed completely");
        }

        public IResult Update(Customer user)
        {
            _customerDal.Update(user);
            return new SuccessResult("Customer updated!");

        }
    }
}
