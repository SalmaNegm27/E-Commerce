namespace Adresses.UnitOfWorks
{
    
 

    public class AddressUnitOfWork : BaseUnitOfWork<Address>, IAddressUnitOfWork
    {
        public AddressUnitOfWork(IAddressRepository adressRepository) : base(adressRepository)
        {
        }
    }
}