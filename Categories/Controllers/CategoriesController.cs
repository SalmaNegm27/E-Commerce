
namespace Categories.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : BaseController<Category, CategoryViewModel>
    {
        public CategoriesController(ICategoryUnitOfWork categoryUnitOfWork, IMapper mapper, IValidator<CategoryViewModel> categoryViewModel) : base(categoryUnitOfWork, mapper, categoryViewModel)
        {
        }
    }
}
