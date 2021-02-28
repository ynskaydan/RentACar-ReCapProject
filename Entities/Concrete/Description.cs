using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Description:IEntity
    {
        public int DescriptionId { get; set; }
        public string DescriptionStr { get; set; }
    }
}
