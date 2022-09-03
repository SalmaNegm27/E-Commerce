namespace Orders.UnitOfWorks
{
    
    
    using ECommerce.Application;
    using Orders.Entities;
    using Orders.Repositories;

    public class OrderUnitOfWork : BaseUnitOfWork<Order>, IOrderUnitOfWork
    {
        public OrderUnitOfWork(IOrderRepository orderRepository) : base(orderRepository)
        {
        }
    }
}