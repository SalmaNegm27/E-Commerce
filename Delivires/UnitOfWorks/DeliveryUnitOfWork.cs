namespace Delivires.UnitOfWorks
{
    using Delivires.Entities;
    using Delivires.Repositories;
    using ECommerce.Application;


    public class DeliveryUnitOfWork : BaseUnitOfWork<Delivery>, IDeliveryUnitOfWork
    {
        public DeliveryUnitOfWork(IDeliveryRepository orderRepository) : base(orderRepository)
        {
        }
    }
}