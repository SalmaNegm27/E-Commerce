namespace Categories.Validators
{
    
    public class CategoryValidator : AbstractValidator<CategoryViewModel>
    {
        public CategoryValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(p => p.Name).MaximumLength(20).WithMessage("Max Length is 20");

        }
    }
}
