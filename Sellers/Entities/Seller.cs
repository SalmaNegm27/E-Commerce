namespace Sellers.Entities
{


    public class Seller : BaseEntity
    {
        public string SellerName { get; set; }
        public List<Product> products { get; set; }

    }
}
