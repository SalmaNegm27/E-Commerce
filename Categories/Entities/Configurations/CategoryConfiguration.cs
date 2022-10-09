namespace ECommerce.Entities.Configurations
{
   
    public class CategoryConfiguration : BaseEntityConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

          
            builder.Property(c => c.Name).IsRequired().HasMaxLength(400);
            builder.Property(c => c.NameSecondLanguage).IsRequired().HasMaxLength(400);

            builder.Property(p => p.Description).IsRequired().HasMaxLength(5000);
            builder.Property(p => p.DescriptionSecondLanguage).IsRequired().HasMaxLength(5000);

            builder.HasMany(p => p.ProductCategories).WithOne().HasForeignKey(p => p.CategoryId);


        }
    }
}