using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryTypeDal : ITypesDal
    {
        public void Add(Types entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Types entity)
        {
            throw new NotImplementedException();
        }

        public Types Get(Expression<Func<Types, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Type> GetAll(Expression<Func<Type, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Types> GetAll(Expression<Func<Types, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Type entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Types entity)
        {
            throw new NotImplementedException();
        }
    }
}
