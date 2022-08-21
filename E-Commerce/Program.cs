using Categories.Entities;
using Categories.Repositories;
using Categories.UnitOfWorks;
using Categories.Validators;
using Categories.ViewModels;
using ECommerce;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Products.Entities;
using System.Reflection.Emit;

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

builder.Services.AddAutoMapper(typeof(Program).Assembly, typeof(Product).Assembly,typeof(Category).Assembly);


builder.Services.AddScoped<IValidator<ProductViewModel>, ProductValidator>();
builder.Services.AddScoped<IValidator<CategoryViewModel>, CategoryValidator>();





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

app.UseAuthorization();

app.MapControllers();

app.Run();
