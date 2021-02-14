using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;

        public InMemoryColorDal(List<Color> colors)
        {
            _colors = colors;


            _colors = new List<Color>()
            {
             new Color(){ColorId=1,ColorName="Red"},
             new Color(){ColorId=2,ColorName="Black"},
             new Color(){ColorId=3,ColorName="Gray"},
             new Color(){ColorId=4,ColorName="Green"},
             new Color(){ColorId=5,ColorName="White"},
             new Color(){ColorId=6,ColorName="Blue"},
             new Color(){ColorId=7,ColorName="Purple"},

            };

        }

        public void Add(Color entity)
        {
            _colors.Add(entity);
        }

        public void Delete(Color entity)
        {
            Color colorToDelete = _colors.SingleOrDefault(cx => cx.ColorId == entity.ColorId);
            _colors.Remove(colorToDelete);
        }

        public Color Get(Expression<Func<Color, bool>> filtr)
        {
            return _colors.SingleOrDefault();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return _colors.ToList();
                
        }

        public void Update(Color entity)
        {
            Color colorToUpdate = _colors.SingleOrDefault(cx => cx.ColorId == entity.ColorId);
            colorToUpdate.ColorId = entity.ColorId;
            colorToUpdate.ColorName = entity.ColorName;
        }
    }
}
