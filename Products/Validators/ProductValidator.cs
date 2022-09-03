﻿namespace Products.Validators
{
    using FluentValidation;
    using Products.ViewModels;

    public class ProductValidator : AbstractValidator<ProductViewModel>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(p => p.Name).MaximumLength(20).WithMessage("Max Length is 20");

        }
    }
}
