namespace ECommerce
{
    using ECommerce.Application;

    public class Category : BaseEntity
    {
       
        public string Description { get; set; }
        public string DescriptionSecondLanguage { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}