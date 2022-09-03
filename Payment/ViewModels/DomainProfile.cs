namespace Payments.ViewModels
{
    using AutoMapper;
    using Payments.Entities;
    using Payments.ViewModels;

    public class DomainProfile : Profile
    {
        public DomainProfile()
        {

            CreateMap<Payment, PaymentViewModel>().ReverseMap();
        }
    }
}


