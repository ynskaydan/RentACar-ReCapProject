using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfUserRepositoryBase<User, RentCarContext>, IUserDal
    {
        public List<UserDto> GetAllDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var details = from u in context.Users
                              join c in context.Customers on u.UserId equals c.UserId
                              select new UserDto
                              {
                                  UserId = u.UserId,
                                  Name = u.Name,
                                  Surname = u.Surname,
                                  Email = u.Email,
                                  CompanyName = c.CompanyName

                              };
                return details.ToList();
            }
        }
    }
}
