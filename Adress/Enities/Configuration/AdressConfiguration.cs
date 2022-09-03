namespace Adresses.Enities.Configuration
{
    using ECommerce.Application;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AdressConfiguration : BaseEntityConfiguration<Adress>
    {
        public override void Configure(EntityTypeBuilder<Adress> builder)
        {
            builder.ToTable("Adrersses");
            builder.Property(pc => pc.Street).IsRequired().HasMaxLength(255);
            builder.Property(pc => pc.City).IsRequired();
            builder.Property(pc => pc.Country).IsRequired().HasMaxLength(30);
            builder.Property(pc => pc.PostCode).IsRequired().HasMaxLength(6);
            builder.Property(pc => pc.PhoneNumber).IsRequired().HasMaxLength(11);



        }
    }
}
