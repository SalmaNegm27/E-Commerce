namespace Categories.UnitOfWorks
{
    using Categories.Entities;
    using Categories.Repositories;
    using ECommerce.Application;

    public class CategoryUnitOfWork : BaseUnitOfWork<Category>, ICategoryUnitOfWork
    {
        public CategoryUnitOfWork(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
        }
    }
}