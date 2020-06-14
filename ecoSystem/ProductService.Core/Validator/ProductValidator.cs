using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using ProductService.Core.Domain;

namespace ProductService.Core.Validator
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(5).MaximumLength(50);
            RuleFor(x => x.Description).NotEmpty().MinimumLength(5).MaximumLength(255);
            RuleFor(x => x.Category).NotNull();
        }
    }
}
