namespace Customers.UnitOfWorks
{
   

    public class CustomerUnitOfWork : BaseUnitOfWork<Customer>, ICustomerUnitOfWork
    {
        public CustomerUnitOfWork(ICustomerRepository customerRepository) : base(customerRepository)
        {
        }
    }
}