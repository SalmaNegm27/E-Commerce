﻿namespace Orders.Validators
{
   
   
    public class OrderValidator : AbstractValidator<OrderViewModel>
    {
        public OrderValidator()
        {
          RuleFor(o=>o.BasePrice).NotEmpty().WithMessage("Base price aan not be empty");   
          RuleFor(o=>o.FinalPrice).NotEmpty();


        }
    }
}
