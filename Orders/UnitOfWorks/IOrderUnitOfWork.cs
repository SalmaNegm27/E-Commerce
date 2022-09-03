namespace Orders.UnitOfWorks
{
    
    using ECommerce.Application;
    using Orders.Entities;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

public interface IOrderUnitOfWork : IBaseUnitOfWork<Order>
{
    
}

}
