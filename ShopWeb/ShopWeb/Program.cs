using Microsoft.EntityFrameworkCore;
using ShopWeb.Data.Context;
using ShopWeb.Data.Daos;
using ShopWeb.Data.Interfaces;

var builder =WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ShopWebContext>(options =>
                                                options.UseSqlServer(builder.Configuration.GetConnectionString
                                                 ("DBshop")));

builder.Services.AddTransient<ICategories, DaoCategories>();
builder.Services.AddTransient<ICustomers, DaoCustomers>();
builder.Services.AddTransient<IProducts, DaoProducts>();
builder.Services.AddTransient<ISuppliers, DaoSuppliers>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
