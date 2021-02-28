using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class TypeOfVehicleValidator:AbstractValidator<TypeOfVehicle>
    {
        public TypeOfVehicleValidator()
        {
            RuleFor(t => t.TypeOfVehicleName).MinimumLength(3);
            RuleFor(t => t.TypeOfVehicleName).NotEmpty();
            
        }

    }
}
