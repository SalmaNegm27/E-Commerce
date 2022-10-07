namespace Products.Entities.Configurations
{
    using ECommerce.Application;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Orders.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
