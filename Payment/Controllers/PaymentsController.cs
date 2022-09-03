
namespace Payments.Controllers
{
    using AutoMapper;
    using ECommerce.Application;
    using FluentValidation;
    using Microsoft.AspNetCore.Mvc;
    using Payments.Entities;
    using Payments.UnitOfWorks;
    using Payments.ViewModels;

    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : BaseController<Payment, PaymentViewModel>
    {
        public PaymentsController(IPaymentUnitOfWork paymentUnitOfWork, IMapper mapper, IValidator<PaymentViewModel> paymentViewModel) : base(paymentUnitOfWork, mapper, paymentViewModel)
        {
        }
    }
}
