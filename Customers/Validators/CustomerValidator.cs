namespace Customers.Validators
{
    
    public class CustomerValidator : AbstractValidator<CustomerViewModel>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.CustomerName).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(p => p.ContactAddress).NotEmpty();

        }
    }
}
