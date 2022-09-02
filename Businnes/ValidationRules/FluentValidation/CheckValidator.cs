using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CheckValidator : AbstractValidator<Check>
    {
        public CheckValidator()
        {
            RuleFor(m => m.Date).NotEmpty();
            RuleFor(m => m.Description).NotEmpty();
            RuleFor(m => m.Image).NotEmpty();
            RuleFor(m => m.Person).NotEmpty();

        }
    }
}
