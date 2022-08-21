﻿namespace Products.Entities
{
    using ECommerce;
    using ECommerce.Application;

    public class Product : BaseEntity

    {
       
        public string Description { get; set; }
        public string DescriptionSecondLanguage { get; set; }
        
        public string ImagePath { get; set; }
        //public byte[] Image { get; set; }
        public decimal Price { get; set; }
        public float Rate { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}