namespace Categories.ViewModels
{
    using Adresses.Enities;
    using AutoMapper;
   

    public class DomainProfile : Profile
    {
        public DomainProfile()
        {

            CreateMap<Adress, AdressViewModel>().ReverseMap();
        }
    }
}


