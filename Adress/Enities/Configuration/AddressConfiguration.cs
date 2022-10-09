namespace Adresses.Enities.Configuration
{
   
    public class AddressConfiguration : BaseEntityConfiguration<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Adrersses");
            builder.Property(pc => pc.Street).IsRequired().HasMaxLength(255);
            builder.Property(pc => pc.City).IsRequired();
            builder.Property(pc => pc.Country).IsRequired().HasMaxLength(30);
            builder.Property(pc => pc.PostCode).IsRequired().HasMaxLength(6);
            builder.Property(pc => pc.PhoneNumber).IsRequired().HasMaxLength(11);



        }
    }
}
