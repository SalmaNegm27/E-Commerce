namespace Adresses.UnitOfWorks
{
    
    
   
    using ECommerce.Application;
    using Adresses.Enities;

    public class AdressUnitOfWork : BaseUnitOfWork<Adress>, IAdressUnitOfWork
    {
        public AdressUnitOfWork(IAdressRepository adressRepository) : base(adressRepository)
        {
        }
    }
}