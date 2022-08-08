namespace ECommerce.ViewModels
{
    using AutoMapper;

    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
