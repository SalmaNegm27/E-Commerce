namespace ECommerce
{
    using ECommerce.Application;

    public class ProductUnitOfWork : BaseUnitOfWork<Product>, IProductUnitOfWork
    {
        public ProductUnitOfWork(IBaseRepository<Product> baseRepository) : base(baseRepository)
        {
        }
    }
}