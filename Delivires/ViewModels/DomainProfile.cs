namespace Delivires.ViewModels
{

    public class DomainProfile : Profile
    {
        public DomainProfile()
        {

            CreateMap<Delivery, DeliveryViewModel>().ReverseMap();
        }
    }
}


