using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using ProductService.Core.Domain;

namespace ProductService.Core.Validator
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(5).MaximumLength(50);
        }
    }
}
