namespace Delivires.Entities.EntityConfiguration
{
   
    public class DeliveryConfiguration :BaseEntityConfiguration<Delivery>
    {
        public override void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.ToTable("deliveries");
            builder.HasKey(d=>d.Id);
            builder.Property(d => d.Name).IsRequired().HasMaxLength(20);

            builder.HasOne(d => d.Order).WithOne().HasForeignKey<Delivery>(d=>d.OrderId);
            builder.HasOne(d => d.Address).WithOne().HasForeignKey<Delivery>(d => d.AddressId);

        }

    }
}
