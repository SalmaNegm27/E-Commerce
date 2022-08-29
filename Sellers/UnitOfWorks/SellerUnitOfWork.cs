namespace Categories.UnitOfWorks
{
    
    using Categories.Repositories;
    using Customers.Entities;
    using ECommerce.Application;

    public class SellerUnitOfWork : BaseUnitOfWork<Seller>, ISellerUnitOfWork
    {
        public SellerUnitOfWork(ISellerRepository sellerRepository) : base(sellerRepository)
        {
        }
    }
}