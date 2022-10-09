
namespace Delivires.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveriesController : BaseController<Delivery, DeliveryViewModel>
    {
        public DeliveriesController(IDeliveryUnitOfWork deliveryUnitOfWork, IMapper mapper, IValidator<DeliveryViewModel> deliveryViewModel) : base(deliveryUnitOfWork, mapper, deliveryViewModel)
        {
        }
    }
}
