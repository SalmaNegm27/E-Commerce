namespace Sellers.ViewModels
{

    public class DomainProfile : Profile
    {
        public DomainProfile()
        {

            CreateMap<Seller, SellerViewModel>().ReverseMap();
        }
    }
}


