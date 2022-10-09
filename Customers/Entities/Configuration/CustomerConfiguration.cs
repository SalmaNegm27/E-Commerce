namespace Customers.Entities.Configuration
{
  

    public class CustomerConfiguration :BaseEntityConfiguration<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("customers");
            builder.Property(c => c.CustomerName).IsRequired().HasMaxLength(255);
            builder.Property(c=>c.ContactAddress).IsRequired().HasMaxLength(11);

            builder.HasOne(c => c.Adress).WithOne().HasForeignKey<Customer>(c => c.AdreesId);
            builder.HasOne<IdentityUser>().WithOne().HasForeignKey<Customer>(c => c.UserId);




        }
    }
}
