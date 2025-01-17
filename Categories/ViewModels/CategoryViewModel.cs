﻿namespace Categories.ViewModels
{
    

    public class CategoryViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string NameSecondLanguage { get; set; }
        public string Description { get; set; }
        public string DescriptionSecondLanguage { get; set; }

        public List<ProductCategoryViewModel> productCategories { get; set; }
    }
}