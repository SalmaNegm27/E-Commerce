namespace Payments.Repositories
{
    
    using ECommerce;
    using ECommerce.Application;
    using Microsoft.EntityFrameworkCore;
    using Payments.Entities;

    public class PaymentRepository : BaseRepositpry<Payment>, IPaymentRepository
    {
        public PaymentRepository(DbContext context) : base(context)
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
        