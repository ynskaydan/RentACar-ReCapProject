using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryTypeDal : ITypeOfVehicleDal
    {
        public void Add(TypeOfVehicle entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TypeOfVehicle entity)
        {
            throw new NotImplementedException();
        }

        public TypeOfVehicle Get(Expression<Func<TypeOfVehicle, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Type> GetAll(Expression<Func<Type, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<TypeOfVehicle> GetAll(Expression<Func<TypeOfVehicle, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Type entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TypeOfVehicle entity)
        {
            throw new NotImplementedException();
        }
    }
}
