namespace Products.UnitOfWorks
{
    using ECommerce.Application;
    using global::Products.Entities;
    using Products.Reposirories;

    public class ProductUnitOfWork : BaseUnitOfWork<Product>, IProductUnitOfWork
    {
        public ProductUnitOfWork(IProductRepository productRepository) : base(productRepository)
        {
        }
    }
}