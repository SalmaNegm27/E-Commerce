namespace Categories.ViewModels
{
    using Adresses.Enities;
    
   

    public class DomainProfile : Profile
    {
        public DomainProfile()
        {

            CreateMap<Address, AddressViewModel>().ReverseMap();
        }
    }
}


