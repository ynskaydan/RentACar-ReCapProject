using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        [ValidationAspect(typeof(RentalValidator),Priority=1)]
        public IResult Add(Rental entity)
        {
            if (_rentalDal.Get(r=> r.RentalId == entity.RentalId) != null)
            {
                if (GetCarAvaible(entity).Success == false )
                {
                    return new ErrorResult(GetCarAvaible(entity).Message); 
                }
                
            }
            _rentalDal.Add(entity);
            return new SuccessResult("Rent process started.");




        }

        public IResult Delete(Rental entity)
        {
            _rentalDal.Delete(entity);
            return new SuccessResult("Rent has removed.");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), "All Rentals Get and Listed");
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentalId == id),"Rental got");
        }

        public IResult GetCarAvaible(Rental rental)
        {
           var recar = _rentalDal.GetAll(r => r.CarId == rental.CarId);
            if (recar.Count > 0)
            {
                foreach (var rx in recar)
                {
                    if (rx.ReturnDate == null)
                    {
                        return new ErrorResult("You cannot rent this car");
                        
                    }


                }
            }
            return new SuccessResult("You can rent this car");

        }

        public IResult Update(Rental entity)
        {
            _rentalDal.Update(entity);
            return new SuccessResult("Rent has updated.");
        }
    }
}
