namespace Orders.Repositories
{
   
    using ECommerce.Application;
    using Microsoft.EntityFrameworkCore;
    using Orders.Entities;

    public class OrderRepository : BaseRepositpry<Order>, IOrderRepository
    {
        public OrderRepository(DbContext context) : base(context)
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
        