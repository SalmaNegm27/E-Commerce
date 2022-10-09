namespace Payments.Entities.Cofiguration
{
    
    public class PaymentConfiguration : BaseEntityConfiguration<Payment>
    {
        public override void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payments");
            builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
            builder.Property(p=> p.NameSecondLanguges).IsRequired().HasMaxLength(255);
            builder.Property(p => p.CardNumber).IsRequired().HasMaxLength(14);
            builder.Property(p => p.Amount).IsRequired();
            builder.HasOne(p=>p.Order).WithOne().HasForeignKey<Payment>(p=>p.OrderId);



        }
    }
}
