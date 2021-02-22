using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Types:IEntity
    {
        public int TypesId { get; set; }
        public string TypesName { get; set; }
    }
}
