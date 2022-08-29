namespace Categories.ViewModels
{


    using AutoMapper;
    using Customers.Entities;

    public class DomainProfile : Profile
    {
        public DomainProfile()
        {

            CreateMap<Customer, CustomerViewModel>().ReverseMap();
        }
    }
}


