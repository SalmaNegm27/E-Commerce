namespace ECommerce
{
    using ECommerce.Application;

    public class ProductUnitOfWork : BaseUnitOfWork<Product>, IProductUnitOfWork
    {
        public ProductUnitOfWork(IProductRepository productRepository) : base(productRepository)
        {
        }
    }
}