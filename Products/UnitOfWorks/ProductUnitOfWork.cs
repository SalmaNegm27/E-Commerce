namespace Products.UnitOfWorks
{
    

    public class ProductUnitOfWork : BaseUnitOfWork<Product>, IProductUnitOfWork
    {
        public ProductUnitOfWork(IProductRepository productRepository) : base(productRepository)
        {
        }
    }
}