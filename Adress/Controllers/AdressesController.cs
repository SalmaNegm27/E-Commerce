
namespace Adresses.Controllers
{
    using Adresses.Enities;
    using Adresses.UnitOfWorks;
    using AutoMapper;
    using Categories.ViewModels;
   
    using ECommerce.Application;
    using FluentValidation;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class AdressesController : BaseController<Adress, AdressViewModel>
    {
        public AdressesController(IAdressUnitOfWork adressUnitOfWork, IMapper mapper, IValidator<AdressViewModel> adressViewModel) : base(adressUnitOfWork, mapper, adressViewModel)
        {
        }
    }
}
