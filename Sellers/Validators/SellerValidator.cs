namespace Sellers.Validators
{
   
    
    public class SellerValidator : AbstractValidator<SellerViewModel>
    {
        public SellerValidator()
        {
            RuleFor(p => p.SellerName).NotEmpty().WithMessage("Name cannot be empty");
           

        }
    }
}
