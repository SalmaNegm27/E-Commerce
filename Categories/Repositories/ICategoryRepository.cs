namespace Categories.Repositories
{
    using Categories.Entities;
    using ECommerce.Application;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public interface ICategoryRepository : IBaseRepository<Category>
    {
       
    }
}