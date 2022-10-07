namespace Orders.Entities.Configuration
{
    using ECommerce.Application;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
