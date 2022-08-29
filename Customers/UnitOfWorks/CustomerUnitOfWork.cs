namespace Categories.UnitOfWorks
{
    
    using Categories.Repositories;
    using Customers.Entities;
    using ECommerce.Application;

    public class CustomerUnitOfWork : BaseUnitOfWork<Customer>, ICustomerUnitOfWork
    {
        public CustomerUnitOfWork(ICustomerRepository customerRepository) : base(customerRepository)
        {
        }
    }
}