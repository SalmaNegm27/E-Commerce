namespace Sellers.UnitOfWorks
{
    
    
    using Customers.Entities;
    using ECommerce.Application;
    using Sellers.Entities;
    using Sellers.Repositories;

    public class SellerUnitOfWork : BaseUnitOfWork<Seller>, ISellerUnitOfWork
    {
        public SellerUnitOfWork(ISellerRepository sellerRepository) : base(sellerRepository)
        {
        }
    }
}