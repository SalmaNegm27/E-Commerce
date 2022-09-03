namespace Payments.ViewModels
{
    using ECommerce.Application;
  

    public class PaymentViewModel : BaseViewModel
    {
        public string Name { get; set; }

        public string NameSecondLanguges { get; set; }
        public int CardNumber { get; set; }
        public string Amount { get; set; }
    }


}
