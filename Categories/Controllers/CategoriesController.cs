
namespace Categories.Controllers
{
    using AutoMapper;
    using Categories.Entities;
    using Categories.UnitOfWorks;
    using Categories.ViewModels;
    using ECommerce.Application;
    using FluentValidation;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : BaseController<Category, CategoryViewModel>
    {
        public CategoriesController(ICategoryUnitOfWork categoryUnitOfWork, IMapper mapper, IValidator<CategoryViewModel> categoryViewModel) : base(categoryUnitOfWork, mapper, categoryViewModel)
        {
        }
    }
}
