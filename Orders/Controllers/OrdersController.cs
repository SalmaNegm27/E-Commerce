
namespace Orders.Controllers
{
  

    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : BaseController<Order, OrderViewModel>
    {
        public OrdersController(IOrderUnitOfWork orderUnitOfWork, IMapper mapper, IValidator<OrderViewModel> orderViewModel) : base(orderUnitOfWork, mapper, orderViewModel)
        {
        }
    }
}
