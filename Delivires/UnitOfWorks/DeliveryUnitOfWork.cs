namespace Delivires.UnitOfWorks
{
   
    public class DeliveryUnitOfWork : BaseUnitOfWork<Delivery>, IDeliveryUnitOfWork
    {
        public DeliveryUnitOfWork(IDeliveryRepository orderRepository) : base(orderRepository)
        {
        }
    }
}