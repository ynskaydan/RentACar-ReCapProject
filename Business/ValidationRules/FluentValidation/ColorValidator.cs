﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator:AbstractValidator<Color>
    {
        public ColorValidator()
        {
            
            RuleFor(b => b.ColorName).MinimumLength(3);
            RuleFor(b => b.ColorName).NotEmpty();
        }
       
    }
}
