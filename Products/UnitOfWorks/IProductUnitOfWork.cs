namespace Products.UnitOfWorks
{
using ECommerce.Application;
using global::Products.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IProductUnitOfWork : IBaseUnitOfWork<Product>

    {

    }

    
}
