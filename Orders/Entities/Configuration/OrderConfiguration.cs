namespace Orders.Entities.Configuration
{
    
    public class OrderConfiguration :BaseEntityConfiguration<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("orders");
            builder.Property(o=>o.BasePrice).IsRequired();
            builder.Property(o => o.FinalPrice).IsRequired();
            builder.HasMany(o=>o.OrderProducts).WithOne().HasForeignKey(o=>o.OrderId);


        }
    }
}
