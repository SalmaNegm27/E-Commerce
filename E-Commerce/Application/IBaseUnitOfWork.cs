namespace ECommerce.Application
{
    public interface IBaseUnitOfWork<T> where T :class
    {
       Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(Guid id);
        Task<List<T>> ReadAsync();
        Task<T> ReadByIdAsync(Guid id);
     
    }
}
