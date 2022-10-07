namespace Delivires.ViewModels
{


    using AutoMapper;
    using Delivires.Entities;

    public class DomainProfile : Profile
    {
        public DomainProfile()
        {

            CreateMap<Delivery, DeliveryViewModel>().ReverseMap();
        }
    }
}


