namespace Products.ViewModels
{
   
    public class ProductCategoryViewModel :BaseViewModel
    {
      

        public Guid ProductId { get; set; }
        public ProductViewModel Product { get; set; }

        public Guid CategoryId { get; set; }
    }
}
