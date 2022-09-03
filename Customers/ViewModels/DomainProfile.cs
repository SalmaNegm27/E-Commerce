namespace Customers.ViewModels
{


    using AutoMapper;
    using Categories.ViewModels;
    using Customers.Entities;

    public class DomainProfile : Profile
    {
        public DomainProfile()
        {

            CreateMap<Customer, CustomerViewModel>().ReverseMap();
        }
    }
}


