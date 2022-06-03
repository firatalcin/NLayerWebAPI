using Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validations
{
    public class ProductDtoValidator : AbstractValidator<ProductDto>
    {
        public ProductDtoValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("{PropertyName} must be greater 0");
            RuleFor(x => x.Stock).GreaterThan(0).WithMessage("{PropertyName} must be greater 0");
            RuleFor(x => x.CategoryId).GreaterThan(0).WithMessage("{PropertyName} must be greater 0");
        }
    }
}
