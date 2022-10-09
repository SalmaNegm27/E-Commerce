namespace Sellers.UnitOfWorks
{
   

    public class SellerUnitOfWork : BaseUnitOfWork<Seller>, ISellerUnitOfWork
    {
        public SellerUnitOfWork(ISellerRepository sellerRepository) : base(sellerRepository)
        {
        }
    }
}