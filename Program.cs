using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using DSR_KAZAR_N1.dbContexts;
using Microsoft.AspNetCore.Identity;
using DSR_KAZAR_N1.Migrations;
using DSR_KAZAR_N1.Models;
using UporabnikZGesli = DSR_KAZAR_N1.Models.UporabnikZGesli;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add DbContext to the service container
builder.Services.AddDbContext<dbContext>(options =>
{
    // Configure DbContext to use SQLite
    options.UseSqlite("Data Source=C:\\fax frfr\\2.letnik\\DSR\\Naloga1\\DSR_KAZAR_N1\\Data\\dsr.db");
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    // Configure DbContext to use SQLite
    options.UseSqlite("Data Source=C:\\fax frfr\\2.letnik\\DSR\\Naloga1\\DSR_KAZAR_N1\\Data\\UserInfo.db");
});

builder.Services.AddIdentity<UporabnikZGesli, IdentityRole>(
        options => {
            options.SignIn.RequireConfirmedAccount = false;
        }
        )
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings.
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;

    // Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    // User settings.
    options.User.AllowedUserNameCharacters =
    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = false;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie settings
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

    options.LoginPath = "/Identity/Account/Login";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.SlidingExpiration = true;
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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
