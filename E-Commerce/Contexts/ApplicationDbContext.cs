namespace ECommerce
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Products.Entities;
    using Categories.Entities;
    using Orders.Entities;
    using Payments.Entities;
    using Adresses.Enities;
    using Sellers.Entities;
    using Customers.Entities;

    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Product).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Category).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Order).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Payment).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Adress).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Seller).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Customer).Assembly);




        }
    }
}