
namespace Categories.Controllers
{
    using AutoMapper;
  
    using Categories.UnitOfWorks;
    using Categories.ViewModels;
    using Customers.Entities;
    using ECommerce.Application;
    using FluentValidation;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class SellersController : BaseController<Seller, SellerViewModel>
    {
        public SellersController(ISellerUnitOfWork customerUnitOfWork, IMapper mapper, IValidator<SellerViewModel> customerViewModel) : base(customerUnitOfWork, mapper, customerViewModel)
        {
        }
    }
}
