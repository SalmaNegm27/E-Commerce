namespace Customers.Entities.Configuration
{
    using ECommerce.Application;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Sellers.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SellerConfiguration :BaseEntityConfiguration<Seller>
    {
        public override void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.ToTable("sellers");
            builder.Property(pc => pc.SellerName).IsRequired().HasMaxLength(30);
         
        }
    }
}
