namespace Payments.UnitOfWorks
{
   
   
    public class PaymentUnitOfWork : BaseUnitOfWork<Payment>, IPaymentUnitOfWork
    {
        public PaymentUnitOfWork(IPaymentRepository paymentRepository) : base(paymentRepository)
        {
        }
    }
}