namespace Sellers.Validators
{
   
    using FluentValidation;
    using Sellers.ViewModels;

    public class SellerValidator : AbstractValidator<SellerViewModel>
    {
        public SellerValidator()
        {
            RuleFor(p => p.SellerName).NotEmpty().WithMessage("Name cannot be empty");
           

        }
    }
}
