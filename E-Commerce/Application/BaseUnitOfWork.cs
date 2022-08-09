namespace ECommerce.Application
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public class BaseUnitOfWork<T> : IBaseUnitOfWork<T> where T : BaseEntity
    {
        protected ApplicationDbContext _context;

        private readonly IBaseRepository<T> _baseRepository;
        public BaseUnitOfWork(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
            _context = baseRepository.Context;
        }

        public async Task<T> CreateAsync(T entity)
        {
          return await _baseRepository.AddAsync(entity);
          await  _context.SaveChangesAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
          await   _baseRepository.EditAsync(entity);
          await _context.SaveChangesAsync();
            return entity;
           
        }

        public async Task<T> DeleteAsync(Guid id)
        {
           T result= await _baseRepository.DeleteAsync(id);
            await _context.SaveChangesAsync();
            return result;

        }

        public async Task<List<T>> ReadAsync()
        {
            List<T> values = await _baseRepository.GetAllAsync();
           await _context.SaveChangesAsync();
            return values;
        }

        public async Task<T> ReadByIdAsync(Guid id)
        {
           T result =   await _baseRepository.GetByIdAsync(id);
          await   _context.SaveChangesAsync();
            return result;
        }
    }
}
