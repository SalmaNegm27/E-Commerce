namespace Customers.ViewModels
{

    public class DomainProfile : Profile
    {
        public DomainProfile()
        {

            CreateMap<Customer, CustomerViewModel>().ReverseMap();
        }
    }
}


