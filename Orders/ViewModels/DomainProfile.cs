namespace Orders.ViewModels
{


    using AutoMapper;
    using Orders.Entities;

    public class DomainProfile : Profile
    {
        public DomainProfile()
        {

            CreateMap<Order, OrderViewModel>().ReverseMap();
        }
    }
}


