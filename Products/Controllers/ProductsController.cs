
namespace Products.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseController<Product, ProductViewModel>
    {
        public ProductsController(IProductUnitOfWork productUnitOfWork, IMapper mapper, IValidator<ProductViewModel> productViewModel) : base(productUnitOfWork, mapper, productViewModel)
        {
        }
    }
}
