
namespace Orders.Controllers
{
    using AutoMapper;
 
    using ECommerce.Application;
    using FluentValidation;
    using Microsoft.AspNetCore.Mvc;
    using Orders.Entities;
    using Orders.UnitOfWorks;
    using Orders.ViewModels;

    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : BaseController<Order, OrderViewModel>
    {
        public OrdersController(IOrderUnitOfWork orderUnitOfWork, IMapper mapper, IValidator<OrderViewModel> orderViewModel) : base(orderUnitOfWork, mapper, orderViewModel)
        {
        }
    }
}
