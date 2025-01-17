﻿namespace Products.Validators
{
   public class ProductValidator : AbstractValidator<ProductViewModel>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(p =>p.NameSecondLanguage).MaximumLength(20).WithMessage("Max Length is 20");

        }
    }
}
