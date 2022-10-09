
namespace Sellerss.Controllers
{
     
   
    [Route("api/[controller]")]
    [ApiController]
    public class SellersController : BaseController<Seller, SellerViewModel>
    {
        public SellersController(ISellerUnitOfWork customerUnitOfWork, IMapper mapper, IValidator<SellerViewModel> customerViewModel) : base(customerUnitOfWork, mapper, customerViewModel)
        {
        }
    }
}
