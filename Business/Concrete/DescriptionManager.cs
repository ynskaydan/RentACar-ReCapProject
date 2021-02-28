using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DescriptionManager : IDescriptionService
    {
        IDescriptionDal _descriptionDal;

        public DescriptionManager(IDescriptionDal descriptionDal)
        {
            _descriptionDal = descriptionDal;
        }

        public IResult Add(Description entity)
        {
            _descriptionDal.Add(entity);
            return new SuccessResult("Description is successfully added");
        }

        public IResult Delete(Description entity)
        {
            _descriptionDal.Delete(entity);
            return new SuccessResult("Description is completely removed");
        }

        public IDataResult<List<Description>> GetAll()
        {
            return new SuccessDataResult<List<Description>>(_descriptionDal.GetAll(), "All description got)");
        }

        public IDataResult<Description> GetById(int id)
        {
            return new SuccessDataResult<Description>(_descriptionDal.Get(c => c.DescriptionId == id), "Description got");
        }

        public IResult Update(Description entity)
        {
            _descriptionDal.Update(entity);
            return new SuccessResult("This description is updated");
        }
    }
}
