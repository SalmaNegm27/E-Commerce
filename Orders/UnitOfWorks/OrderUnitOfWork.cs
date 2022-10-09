namespace Orders.UnitOfWorks
{
    

    public class OrderUnitOfWork : BaseUnitOfWork<Order>, IOrderUnitOfWork
    {
        public OrderUnitOfWork(IOrderRepository orderRepository) : base(orderRepository)
        {
        }
    }
}