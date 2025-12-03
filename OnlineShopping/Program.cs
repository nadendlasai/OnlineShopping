using Microsoft.EntityFrameworkCore;
using OnlineShopping.Shopping.ApplicationService;
using OnlineShopping.Shopping.Context;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<ShoppingContext>(options =>
    options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=OnlineShopping;Trusted_Connection=True;TrustServerCertificate=True;"));


builder.Services.AddScoped<IAuthApplicationService, AuthApplicationService>();
builder.Services.AddScoped<IDashboardApplicationService, DashboardApplicationService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// to serve css/js/images from wwwroot later
app.UseStaticFiles();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.MapControllers();

app.Run();
