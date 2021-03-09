using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService:IEntityService<CarImage>
    {
        IResult Add(CarImage carImage, IFormFile formFile);
        IResult Update(CarImage carImage, IFormFile formFile);



    }
}
