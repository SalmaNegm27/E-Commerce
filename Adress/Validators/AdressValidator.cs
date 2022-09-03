namespace Categories.Validators
{
    using Categories.ViewModels;
    using FluentValidation;

    public class AdressValidator : AbstractValidator<AdressViewModel>
    {
        public AdressValidator()
        {
            RuleFor(p => p.Street).NotEmpty().WithMessage(" Street Name cannot be empty");
            RuleFor(p => p.City).NotEmpty().WithMessage(" City Name cannot be empty");
            RuleFor(p => p.Country).NotEmpty().WithMessage(" Country Name cannot be empty");
            RuleFor(p => p.PhoneNumber).NotEmpty();



        }
    }
}
