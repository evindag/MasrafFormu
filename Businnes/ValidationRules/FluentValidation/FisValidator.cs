using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businnes.ValidationRules.FluentValidation
{
    public class FisValidator:AbstractValidator<Fis>
    {
        public FisValidator()
        {
            RuleFor(f => f.Aciklama).MinimumLength(10).MaximumLength(300) ;
            RuleFor(f => f.FisTuru).NotEmpty();
            RuleFor(f => f.FisNo).NotEmpty();
            RuleFor(f => f.Kdv).NotEmpty();

        }
    }
}
