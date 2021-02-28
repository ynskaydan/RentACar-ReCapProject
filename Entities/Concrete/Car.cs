﻿
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int TypeOfVehicleId { get; set; }
        public int ModelYear { get; set; }
        public string DescriptionId { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
