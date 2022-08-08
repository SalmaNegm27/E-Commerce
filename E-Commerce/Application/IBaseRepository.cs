namespace ECommerce.Application
{
    using System.Linq.Expressions;

    public interface IBaseRepository<T>
    {
        ApplicationDbContext Context { get; }
        Task<T> AddAsync(T entity);
        Task<T> EditAsync(T entity);
        Task<T> DeleteAsync(Guid id);
        Task<T> GetByIdAsync(Guid id);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetByExprissionAsync(Expression<Func<T, bool>> expression);

    }
}
