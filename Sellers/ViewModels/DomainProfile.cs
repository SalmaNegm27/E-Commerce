namespace Sellers.ViewModels
{


    using AutoMapper;
    using Sellers.Entities;

    public class DomainProfile : Profile
    {
        public DomainProfile()
        {

            CreateMap<Seller, SellerViewModel>().ReverseMap();
        }
    }
}


