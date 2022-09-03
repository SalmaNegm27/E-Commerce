namespace Payments.Entities.Cofiguration
{
    using ECommerce.Application;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
