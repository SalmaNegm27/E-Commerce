
namespace ECommerce
{
    using AutoMapper;
    using ECommerce.Application;
    using FluentValidation;
    using Microsoft.AspNetCore.Mvc;
    using Products.Entities;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseController<Product, ProductViewModel>
    {
        public ProductsController(IProductUnitOfWork productUnitOfWork, IMapper mapper, IValidator<ProductViewModel> productViewModel) : base(productUnitOfWork, mapper, productViewModel)
        {
        }
    }
}
