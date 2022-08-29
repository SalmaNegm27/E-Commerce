namespace Customers.Entities
{
    using ECommerce.Application;
    using Products.Entities;

    public class Seller : BaseEntity
    {
        public string SellerName { get; set; }
        public List<Product> products { get; set; }

    }
}
