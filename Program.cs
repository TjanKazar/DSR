using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add DbContext to the service container
builder.Services.AddDbContext<dbContext>(options =>
{
    // Configure DbContext to use SQLite
    options.UseSqlite("Data Source=C:\\Users\\kazar\\source\\repos\\DSR\\Data\\dsr.db");
});

var app = builder.Build();

// Initialize SQLitePCL
SQLitePCL.Batteries.Init();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
