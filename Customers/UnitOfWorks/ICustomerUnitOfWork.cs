namespace Customers.UnitOfWorks
{
   
    using Customers.Entities;
    using ECommerce.Application;


public interface ICustomerUnitOfWork : IBaseUnitOfWork<Customer>
{
    
}

}
