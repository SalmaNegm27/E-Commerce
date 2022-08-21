namespace ECommerce
{
    using ECommerce.Application;
    using Products.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public interface IProductRepository :IBaseRepository<Product>
    {
       
    }
}