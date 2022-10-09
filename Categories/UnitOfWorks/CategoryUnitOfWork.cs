namespace Categories.UnitOfWorks
{
   

    public class CategoryUnitOfWork : BaseUnitOfWork<Category>, ICategoryUnitOfWork
    {
        public CategoryUnitOfWork(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
        }
    }
}