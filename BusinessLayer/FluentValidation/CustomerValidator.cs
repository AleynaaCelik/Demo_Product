using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(" Müşteri adıboş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Müşteri adı en az 3 karakter olmalıdır.");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir adıboş geçilemez");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Şehir adı en az 3 karakter olmalıdır.");

        }
    }
}
