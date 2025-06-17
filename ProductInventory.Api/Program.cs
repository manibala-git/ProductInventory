using Microsoft.EntityFrameworkCore;
using ProductInventory.Api.Data;
using ProductInventory.Api.Repositories;
using ProductInventory.Api.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<IProductService, ProductServices>();
builder.Services.AddScoped<IProductRepository, ProductRepositories>();

builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapControllers();
app.Run();