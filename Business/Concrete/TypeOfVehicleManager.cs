using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac;
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
    public class TypeOfVehicleManager : ITypeOfVehicleService
    {
        ITypeOfVehicleDal _typeDal;

        public TypeOfVehicleManager(ITypeOfVehicleDal typeDal)
        {
            _typeDal = typeDal;
        }

   
        [ValidationAspect(typeof(TypeOfVehicleValidator),Priority = 1 )]
        public IResult Add(TypeOfVehicle entity)
        {
           
                if (_typeDal.Get(c => c.TypeOfVehicleName == entity.TypeOfVehicleName) == null)
                {
                   
                        _typeDal.Add(entity);
                        return new SuccessResult("Type of Vehicle added succesfully");
                }               
                else
                {
                    return new ErrorResult("You cannot add this Type. Please write a different TypeName");
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

        public IDataResult<TypeOfVehicle> GetById(int id)
        {
            return new SuccessDataResult<TypeOfVehicle>(_typeDal.Get(t => t.TypeOfVehicleId == id), "Type got");
        }

        public IResult Update(TypeOfVehicle entity)
        {
            _typeDal.Update(entity);
            return new SuccessResult("Type of Vehicle updated succesfully");
        }
    }
}
