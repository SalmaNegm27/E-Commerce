
namespace Delivires.Controllers
{
    using AutoMapper;
    using Delivires.Entities;
    using Delivires.UnitOfWorks;
    using Delivires.ViewModels;
    using ECommerce.Application;
    using FluentValidation;
    using Microsoft.AspNetCore.Mvc;
   

    [Route("api/[controller]")]
    [ApiController]
    public class DeliveriesController : BaseController<Delivery, DeliveryViewModel>
    {
        public DeliveriesController(IDeliveryUnitOfWork deliveryUnitOfWork, IMapper mapper, IValidator<DeliveryViewModel> deliveryViewModel) : base(deliveryUnitOfWork, mapper, deliveryViewModel)
        {
        }
    }
}
