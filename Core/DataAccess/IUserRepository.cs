using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IUserRepository<T> where T:class,IUsers,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);

        void Add(T user);
        void Update(T user);
        void Delete(T user);
    }
}
