namespace Categories.ViewModels
{
using Categories.Entities;
using Categories.ViewModels;

    using AutoMapper;

    public class DomainProfile : Profile
    {
        public DomainProfile()
        {

            CreateMap<Category, CategoryViewModel>().ReverseMap();
        }
    }
}


