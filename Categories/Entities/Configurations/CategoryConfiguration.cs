namespace ECommerce.Entities.Configurations
{
    using Categories.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name).IsRequired().HasMaxLength(400);
            builder.Property(c => c.NameSecondLanguage).IsRequired().HasMaxLength(400);

            builder.Property(p => p.Description).IsRequired().HasMaxLength(5000);
            builder.Property(p => p.DescriptionSecondLanguage).IsRequired().HasMaxLength(5000);

            builder.HasMany(p => p.ProductCategories).WithOne().HasForeignKey(p => p.CategoryId);


        }
    }
}