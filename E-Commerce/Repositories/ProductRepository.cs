namespace ECommerce
{
    using ECommerce.Application;
    using Microsoft.EntityFrameworkCore;
    using System.Linq.Expressions;

    public class ProductRepository : BaseRepositpry<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
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
        