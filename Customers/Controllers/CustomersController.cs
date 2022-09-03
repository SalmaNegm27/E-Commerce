
namespace Customers.Controllers
{
    using AutoMapper;
    using Customers.Entities;
    using Customers.UnitOfWorks;
    using Customers.ViewModels;
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
