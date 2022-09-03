namespace Customers.ViewModels
{
    using ECommerce.Application;
  

    public class CustomerViewModel : BaseViewModel
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public int ContactAddress { get; set; }
    }


}
