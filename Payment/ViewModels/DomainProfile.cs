namespace Payments.ViewModels
{
    

    public class DomainProfile : Profile
    {
        public DomainProfile()
        {

            CreateMap<Payment, PaymentViewModel>().ReverseMap();
        }
    }
}


