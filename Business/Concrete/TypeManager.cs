using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class TypeManager : ITypeService
    {
        ITypeDal _typeDal;

        public TypeManager(ITypeDal typeDal)
        {
            _typeDal = typeDal;
        }

   

        public IResult Add(TypeOfVehicle entity)
        {
            if (_typeDal.Get(c => c.TypeId == entity.TypeId) == null)
            {
                if (_typeDal.Get(c => c.TypeName == entity.TypeName) == null)
                {
                    if (_typeDal.Get(c => c.TypeName.Length > 2) != null)
                    {
                        _typeDal.Add(entity);
                        return new SuccessResult("Type of Vehicle added succesfully");
                    }
                    else
                    { 
                        return new ErrorResult("TypeName must be include at least 2 character ");
                    }
                }
                else
                {
                    return new ErrorResult("You cannot add this Type. Please write a different TypeName");
                }

            }
            else
            {
                return new ErrorResult("You cannot add this Type. Please write a different TypeID");
            }
        }

        public IResult Delete(TypeOfVehicle entity)
        {
            _typeDal.Delete(entity);
            return new SuccessResult("Type of Vehicle deleted completely");
        }

        public IDataResult<List<TypeOfVehicle>> GetAll()
        {
            return new SuccessDataResult<List<TypeOfVehicle>>(_typeDal.GetAll(),"All types of vehicle got");
        }

        public IResult Update(TypeOfVehicle entity)
        {
            _typeDal.Update(entity);
            return new SuccessResult("Type of Vehicle updated succesfully");
        }
    }
}
