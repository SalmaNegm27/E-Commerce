namespace Categories.ViewModels
{
    using ECommerce.Application;
  

    public class AdressViewModel : BaseViewModel
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string PostCode { get; set; }

        public int PhoneNumber
        {
            get; set;
        }


}
}