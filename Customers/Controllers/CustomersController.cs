
namespace Customers.Controllers
{
   

    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : BaseController<Customer, CustomerViewModel>
    {
        public CustomersController(ICustomerUnitOfWork customerUnitOfWork, IMapper mapper, IValidator<CustomerViewModel> customerViewModel) : base(customerUnitOfWork, mapper, customerViewModel)
        {
        }
    }
}
