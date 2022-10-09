
namespace Payments.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : BaseController<Payment, PaymentViewModel>
    {
        public PaymentsController(IPaymentUnitOfWork paymentUnitOfWork, IMapper mapper, IValidator<PaymentViewModel> paymentViewModel) : base(paymentUnitOfWork, mapper, paymentViewModel)
        {
        }
    }
}
