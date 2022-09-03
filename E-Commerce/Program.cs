using Adresses.Enities;
using Adresses.UnitOfWorks;
using Categories.Entities;
using Categories.Repositories;
using Categories.UnitOfWorks;
using Categories.Validators;
using Categories.ViewModels;
using Customers.Entities;
using Customers.Repositories;
using Customers.UnitOfWorks;
using Customers.Validators;
using Customers.ViewModels;
using ECommerce;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Orders.Entities;
using Orders.Repositories;
using Orders.UnitOfWorks;
using Orders.Validators;
using Orders.ViewModels;
using Payments.Entities;
using Payments.Repositories;
using Payments.UnitOfWorks;
using Payments.Validators;
using Payments.ViewModels;
using Products.Entities;
using Products.Reposirories;
using Products.UnitOfWorks;
using Products.Validators;
using Products.ViewModels;
using Sellers.Entities;
using Sellers.Repositories;
using Sellers.UnitOfWorks;
using Sellers.Validators;
using Sellers.ViewModels;
using System.Reflection.Emit;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>
    (
options =>
{
options
    .UseSqlServer(connectionString, builder => builder.MigrationsAssembly(typeof(Program).Assembly.FullName))
    .EnableDetailedErrors()
    .EnableSensitiveDataLogging()
    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddScoped<DbContext, ApplicationDbContext>();

        

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryUnitOfWork, CategoryUnitOfWork>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductUnitOfWork, ProductUnitOfWork>();

builder.Services.AddScoped<IAdressRepository, AdressRepository>();
builder.Services.AddScoped<IAdressUnitOfWork, AdressUnitOfWork>();

builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderUnitOfWork, OrderUnitOfWork>();

builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();
builder.Services.AddScoped<IPaymentUnitOfWork, PaymentUnitOfWork>();


builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerUnitOfWork, CustomerUnitOfWork>();

builder.Services.AddScoped<ISellerRepository, SellerRepository>();
builder.Services.AddScoped<ISellerUnitOfWork, SellerUnitOfWork>();



builder.Services.AddAutoMapper(typeof(Program).Assembly, typeof(Product).Assembly,typeof(Category).Assembly,typeof(Adress).Assembly,typeof(Order).Assembly,typeof(Payment).Assembly,typeof(Customer).Assembly, typeof(Seller).Assembly);


builder.Services.AddScoped<IValidator<ProductViewModel>, ProductValidator>();
builder.Services.AddScoped<IValidator<CategoryViewModel>, CategoryValidator>();
builder.Services.AddScoped<IValidator<AdressViewModel>, AdressValidator>();
builder.Services.AddScoped<IValidator<OrderViewModel>, OrderValidator>();
builder.Services.AddScoped<IValidator<PaymentViewModel>, PaymentValidator>();
builder.Services.AddScoped<IValidator<CustomerViewModel>, CustomerValidator>();
builder.Services.AddScoped<IValidator<SellerViewModel>, SellerValidator>();



builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})

    .AddJwtBearer(options =>
    {
        options.SaveToken = true;
        options.RequireHttpsMetadata = false;
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidAudience = builder.Configuration["JWT:ValidAudience"],
            ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
        };

    });


builder.Services.AddMvc();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
