using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adıboş geçilemez");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori adı en az 3 karakter olmalıdır.");
           
        }
    }
}
