using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ReceiptValidator:AbstractValidator<Receipt>
    {
        public ReceiptValidator()
        {
            RuleFor(f => f.Description).MinimumLength(10).MaximumLength(300) ;
            RuleFor(f => f.ReceiptType).NotEmpty();
            RuleFor(f => f.ReceiptNo).NotEmpty();
            RuleFor(f => f.Vat).NotEmpty();

        }
    }
}
