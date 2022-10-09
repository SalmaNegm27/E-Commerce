namespace Orders.ViewModels
{


    
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {

            CreateMap<Order, OrderViewModel>().ReverseMap();
        }
    }
}


