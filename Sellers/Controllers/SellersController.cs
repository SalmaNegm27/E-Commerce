
namespace Sellerss.Controllers
{
    using AutoMapper;
  
    
    using ECommerce.Application;
    using FluentValidation;
    using Microsoft.AspNetCore.Mvc;
    using Sellers.Entities;
    using Sellers.UnitOfWorks;
    using Sellers.ViewModels;

    [Route("api/[controller]")]
    [ApiController]
    public class SellersController : BaseController<Seller, SellerViewModel>
    {
        public SellersController(ISellerUnitOfWork customerUnitOfWork, IMapper mapper, IValidator<SellerViewModel> customerViewModel) : base(customerUnitOfWork, mapper, customerViewModel)
        {
        }
    }
}
