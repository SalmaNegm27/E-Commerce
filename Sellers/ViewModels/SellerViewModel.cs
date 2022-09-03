namespace Sellers.ViewModels
{
    using ECommerce.Application;
    using Products.Entities;

    public class SellerViewModel : BaseViewModel
    {
        public string SellerName { get; set; }
        public List<Product> products { get; set; }
    }


}
