namespace ECommerce
{
    using ECommerce.Application;
    using Products.Entities;

    public class ProductUnitOfWork : BaseUnitOfWork<Product>, IProductUnitOfWork
    {
        public ProductUnitOfWork(IProductRepository productRepository) : base(productRepository)
        {
        }
    }
}