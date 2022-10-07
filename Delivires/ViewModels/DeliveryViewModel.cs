namespace Delivires.ViewModels
{
    using Adresses.Enities;
    using Categories.ViewModels;
    using ECommerce.Application;


    public class DeliveryViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public AdressViewModel Adress { get; set; }
    }
}