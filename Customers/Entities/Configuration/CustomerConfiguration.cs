namespace Customers.Entities.Configuration
{
    using ECommerce.Application;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CustomerConfiguration :BaseEntityConfiguration<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("customers");
            builder.Property(pc => pc.CustomerName).IsRequired().HasMaxLength(255);
            builder.Property(pc => pc.Adderss).IsRequired();
            builder.Property(pc=>pc.ContactAddress).IsRequired().HasMaxLength(11);

           

        }
    }
}
