namespace Delivires.Entities.EntityConfiguration
{
    using ECommerce.Application;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DeliveryConfiguration :BaseEntityConfiguration<Delivery>
    {
        public override void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.ToTable("deliveries");
            builder.HasKey(d=>d.Id);
            builder.Property(d => d.Name).IsRequired().HasMaxLength(20);
            builder.Property(d=>d.Adress).IsRequired().HasMaxLength(255);
            builder.HasOne(d => d.Order).WithOne().HasForeignKey<Delivery>(d=>d.OrderId);
        }

    }
}
