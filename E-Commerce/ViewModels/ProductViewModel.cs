namespace ECommerce
{
    using ECommerce.Application;

    public class ProductViewModel :BaseViewModel
    {
                
        public string Name { get; set; }
        public string Description { get; set; }
        public string DescriptionSecondLanguage { get; set; }

        public string ImagePath { get; set; }
       
        public decimal Price { get; set; }
        public float Rate { get; set; }
        public List<Category> Categories { get; set; }
    }
}