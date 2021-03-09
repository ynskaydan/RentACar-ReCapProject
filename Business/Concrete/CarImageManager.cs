using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

      
        public IResult Add(CarImage carImage, IFormFile formFile)
        {
            var result = BusinessRules.Run(CheckImageLimit(carImage.CarId)).Success;
            if (!result)
            {
                return new ErrorResult(CheckImageLimit(carImage.CarId).Message);
            }
            carImage.ImagePath = FileHelper.Add(formFile);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult();
        }

        public IResult Delete(CarImage entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImage> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            throw new NotImplementedException();
        }


        public IDataResult<List<CarImage>> GetImagesByCarId(int carid)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CarImage carImage, IFormFile formFile)
        {
            throw new NotImplementedException();
        }


        private IResult CheckImageLimit(int carid)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carid).Count;
            if (result > 5)
            {
                return new ErrorResult("You cannot add more than 5 image for just 1 car");
            }
            return new SuccessResult();
        }
    }
}
