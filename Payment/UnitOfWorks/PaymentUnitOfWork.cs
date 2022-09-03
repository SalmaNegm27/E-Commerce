namespace Payments.UnitOfWorks
{
   
    using ECommerce.Application;
    using Payments.Entities;
    using Payments.Repositories;

    public class PaymentUnitOfWork : BaseUnitOfWork<Payment>, IPaymentUnitOfWork
    {
        public PaymentUnitOfWork(IPaymentRepository paymentRepository) : base(paymentRepository)
        {
        }
    }
}