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

    public class ProductOrderConfiguration : IEntityTypeConfiguration<ProductOrder>
    {
        public void Configure(EntityTypeBuilder<ProductOrder> builder)
        {
            builder.ToTable("productOrders");
            builder.HasKey(p=> p.Id);
            builder.HasOne(p => p.Product).WithMany(p => p.ProductOrders).HasForeignKey(p => p.ProductId);
        }
    }
}
