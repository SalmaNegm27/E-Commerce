
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
    public class CustomersController : BaseController<Customer, CustomerViewModel>
    {
        public CustomersController(ICustomerUnitOfWork customerUnitOfWork, IMapper mapper, IValidator<CustomerViewModel> customerViewModel) : base(customerUnitOfWork, mapper, customerViewModel)
        {
        }
    }
}
