namespace Orders.Validators
{
   
    using FluentValidation;
    using Orders.ViewModels;

    public class OrderValidator : AbstractValidator<OrderViewModel>
    {
        public OrderValidator()
        {
          

        }
    }
}
