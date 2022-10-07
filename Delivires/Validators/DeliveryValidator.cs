namespace Delivires.Validators
{
    using Delivires.ViewModels;
    using FluentValidation;
    

    public class DeliveryValidator : AbstractValidator<DeliveryViewModel>
    {
        public DeliveryValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name cannot be empty");
            

        }
    }
}
