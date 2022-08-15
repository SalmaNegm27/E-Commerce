namespace ECommerce.Entities.Configurations
{
    using ECommerce.Application;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ProductConfiguration : BaseEntityConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);

            builder.ToTable("Products");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(5000);
            builder.Property(p => p.DescriptionSecondLanguage).IsRequired().HasMaxLength(5000);
        }
    }
}