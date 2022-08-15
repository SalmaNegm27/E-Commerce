
namespace ECommerce
{
    using AutoMapper;
    using ECommerce.Application;
    using FluentValidation;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseController<Product, ProductViewModel>
    {
        public ProductsController(IBaseUnitOfWork<Product> baseUnitOfWork, IMapper mapper, IValidator<BaseViewModel> validator) : base(baseUnitOfWork, mapper, validator)
        {
        }
    }
}
