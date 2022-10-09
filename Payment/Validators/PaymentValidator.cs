namespace Payments.Validators
{
  
    public class PaymentValidator : AbstractValidator<PaymentViewModel>
    {
        public PaymentValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(p => p.NameSecondLanguges).NotEmpty().WithMessage("Name cannot be empty");

        }
    }
}
