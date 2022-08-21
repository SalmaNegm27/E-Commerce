namespace ECommerce.Entities.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Products.Entities;

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name).IsRequired().HasMaxLength(400);
            builder.Property(c => c.NameSecondLanguage).IsRequired().HasMaxLength(400);

            builder.Property(p => p.Description).IsRequired().HasMaxLength(5000);
            builder.Property(p => p.DescriptionSecondLanguage).IsRequired().HasMaxLength(5000);
        }
    }
}