namespace ECommerce
{
    using ECommerce.Application;
    using Products.Entities;

    public class ProductCategory :BaseEntity
    {
        

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public Guid CategoryId { get; set; }
       
    }
}