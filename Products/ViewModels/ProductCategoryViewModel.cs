namespace Products.ViewModels
{
    using ECommerce.Application;
    using Products.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ProductCategoryViewModel :BaseViewModel
    {
      

        public Guid ProductId { get; set; }
        public ProductViewModel Product { get; set; }

        public Guid CategoryId { get; set; }
    }
}
