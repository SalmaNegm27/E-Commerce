
namespace Products.Controllers
{
    using AutoMapper;
    using ECommerce.Application;
    using FluentValidation;
    using Microsoft.AspNetCore.Mvc;
    using Products.Entities;
    using Products.UnitOfWorks;
    using Products.ViewModels;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseController<Product, ProductViewModel>
    {
        public ProductsController(IProductUnitOfWork productUnitOfWork, IMapper mapper, IValidator<ProductViewModel> productViewModel) : base(productUnitOfWork, mapper, productViewModel)
        {
        }
    }
}
