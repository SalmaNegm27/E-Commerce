namespace Customers.UnitOfWorks
{
    
    using Customers.Entities;
    using Customers.Repositories;
    using ECommerce.Application;

    public class CustomerUnitOfWork : BaseUnitOfWork<Customer>, ICustomerUnitOfWork
    {
        public CustomerUnitOfWork(ICustomerRepository customerRepository) : base(customerRepository)
        {
        }
    }
}