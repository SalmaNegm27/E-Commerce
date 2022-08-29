﻿namespace Categories.Entities
{
using ECommerce;
using ECommerce.Application;


    public class Category : BaseEntity
    {

        public string Name { get; set; }
        public string NameSecondLanguage { get; set; }
        public string Description { get; set; }
        public string DescriptionSecondLanguage { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
