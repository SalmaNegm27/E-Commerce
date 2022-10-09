


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

builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<IAddressUnitOfWork, AddressUnitOfWork>();

builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderUnitOfWork, OrderUnitOfWork>();

builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();
builder.Services.AddScoped<IPaymentUnitOfWork, PaymentUnitOfWork>();


builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerUnitOfWork, CustomerUnitOfWork>();

builder.Services.AddScoped<ISellerRepository, SellerRepository>();
builder.Services.AddScoped<ISellerUnitOfWork, SellerUnitOfWork>();

builder.Services.AddScoped<IDeliveryRepository, DeliveryRepository>();
builder.Services.AddScoped<IDeliveryUnitOfWork, DeliveryUnitOfWork>();





builder.Services.AddAutoMapper(typeof(Program).Assembly, typeof(Product).Assembly,typeof(Category).Assembly,typeof(Address).Assembly,typeof(Order).Assembly,typeof(Payment).Assembly,typeof(Customer).Assembly, typeof(Seller).Assembly,typeof(Delivery).Assembly);


builder.Services.AddScoped<IValidator<ProductViewModel>, ProductValidator>();
builder.Services.AddScoped<IValidator<CategoryViewModel>, CategoryValidator>();
builder.Services.AddScoped<IValidator<AddressViewModel>, AddressValidator>();
builder.Services.AddScoped<IValidator<OrderViewModel>, OrderValidator>();
builder.Services.AddScoped<IValidator<PaymentViewModel>, PaymentValidator>();
builder.Services.AddScoped<IValidator<CustomerViewModel>, CustomerValidator>();
builder.Services.AddScoped<IValidator<SellerViewModel>, SellerValidator>();
builder.Services.AddScoped<IValidator<DeliveryViewModel>, DeliveryValidator>();



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

builder.Services.AddControllers()
    .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);



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
