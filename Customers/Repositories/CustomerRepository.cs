namespace Customers.Repositories
{
    using Customers.Entities;
    using ECommerce;
    using ECommerce.Application;
    using Microsoft.EntityFrameworkCore;
   

    public class CustomerRepository : BaseRepositpry<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext context) : base(context)
        {
        }


    }
}

        //private async Task<bool> IsExists(Guid productId)
        //{
        //    return await _products.AnyAsync(p => p.Id == productId);
        //}
        //private async Task<bool> IsExists(Product product)
        //{
        //    return await _products.AnyAsync(p => p.Id == product.Id);
        