namespace Customers.Validators
{
    using Categories.ViewModels;
    using Customers.ViewModels;
    using FluentValidation;

    public class CustomerValidator : AbstractValidator<CustomerViewModel>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.CustomerName).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(p => p.ContactAddress).NotEmpty();

        }
    }
}
