﻿namespace Common.UnitOfWorks
{
    using Common.Entites;
    using Common.Repositories;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class BaseUnitOfWork<T> : IBaseUnitOfWork<T> where T : BaseEntity
    {
        protected DbContext _context;
        private readonly IBaseRepository<T> _baseRepository;
        public BaseUnitOfWork(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
            _context = baseRepository.DbContext;
        }

        public  virtual async Task<T> CreateAsync(T entity)
        {
            await _baseRepository.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            await _baseRepository.EditAsync(entity);
            await _context.SaveChangesAsync();
            return entity;

        }

        public virtual async Task<T> DeleteAsync(Guid id)
        {
            T result = await _baseRepository.DeleteAsync(id);
            await _context.SaveChangesAsync();
            return result;

        }
        public virtual  async Task<T> ReadByIdAsync(Guid id)
        {
            T result = await _baseRepository.GetByIdAsync(id);
            await _context.SaveChangesAsync();
            return result;
        }

        public virtual Task<IEnumerable<T>> ReadAsync()
        {
            return _baseRepository.GetAllAsync();
        }
    }
}
