namespace Products.Entities.Configurations
{
 
    public class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.ToTable("productOrders");
            builder.HasKey(p=> p.Id);
            builder.HasOne(p => p.Order).WithMany(p => p.OrderProducts).HasForeignKey(p => p.OrderId);
        }
    }
}
