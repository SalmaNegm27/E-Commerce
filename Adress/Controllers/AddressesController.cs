
namespace Adresses.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : BaseController<Address, AddressViewModel>
    {
        public AddressesController(IAddressUnitOfWork addressUnitOfWork, IMapper mapper, IValidator<AddressViewModel> addressViewModel) : base(addressUnitOfWork, mapper, addressViewModel)
        {
        }
    }
}
