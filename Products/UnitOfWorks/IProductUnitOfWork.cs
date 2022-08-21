namespace ECommerce
{
    using ECommerce.Application;
    using Products.Entities;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IProductUnitOfWork : IBaseUnitOfWork<Product>
    {
        
    }
}
