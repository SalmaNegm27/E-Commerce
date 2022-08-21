namespace Products.ViewModels
{
    using AutoMapper;
    using ECommerce;
    using Products.Entities;

    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }
    }
}
