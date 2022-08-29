namespace Categories.Validators
{
    using Categories.ViewModels;
    using FluentValidation;

    public class SellerValidator : AbstractValidator<SellerViewModel>
    {
        public SellerValidator()
        {
            RuleFor(p => p.SellerName).NotEmpty().WithMessage("Name cannot be empty");
           

        }
    }
}
