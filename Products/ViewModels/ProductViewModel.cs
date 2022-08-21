﻿namespace ECommerce
{
    using ECommerce.Application;
    using Products.ViewModels;

    public class ProductViewModel :BaseViewModel
    {
                
        public string Name { get; set; }
        public string NameSecondLanguage { get; set; }
        public string Description { get; set; }
        public string DescriptionSecondLanguage { get; set; }

        public string ImagePath { get; set; }
       
        public decimal Price { get; set; }
        public float Rate { get; set; }
        public List<ProductCategoryViewModel> productCategoryViewModel { get; set; }
    }
}       