namespace Customers.Entities.Configuration
{
   
    public class SellerConfiguration :BaseEntityConfiguration<Seller>
    {
        public override void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.ToTable("sellers");
            builder.Property(pc => pc.SellerName).IsRequired().HasMaxLength(30);
         
        }
    }
}
