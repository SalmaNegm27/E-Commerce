namespace Categories.ViewModels
{

    public class DomainProfile : Profile
    {
        public DomainProfile()
        {

            CreateMap<Category, CategoryViewModel>().ReverseMap();
        }
    }
}


