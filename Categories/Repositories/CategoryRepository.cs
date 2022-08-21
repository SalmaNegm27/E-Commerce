namespace Categories.Repositories
{
    using Categories.Entities;
    using ECommerce;
    using ECommerce.Application;
    using Microsoft.EntityFrameworkCore;
   

    public class CategoryRepository : BaseRepositpry<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
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
        