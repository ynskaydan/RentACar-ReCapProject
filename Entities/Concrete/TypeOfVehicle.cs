using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class TypeOfVehicle:IEntity
    {
        public int TypeOfVehicleId { get; set; }
        public string TypeOfVehicleName { get; set; }
    }
}
