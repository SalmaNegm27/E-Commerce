namespace Delivires.Repositories
{
    using Delivires.Entities;
    using ECommerce.Application;
    using Microsoft.EntityFrameworkCore;
    

    public class DeliveryRepository : BaseRepositpry<Delivery>, IDeliveryRepository
    {
        public DeliveryRepository(DbContext context) : base(context)
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
        