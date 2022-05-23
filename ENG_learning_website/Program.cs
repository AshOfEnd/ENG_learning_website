using ENG_learning_website.Data;
using ENG_learning_website.Data.services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Stripe;
using ENG_learning_website.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("IDBContextConnection");;
builder.Services.AddTransient<DbInitializer>();








builder.Services.AddDbContext<IDBContext>(options =>
    options.UseSqlServer(connectionString));;

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<IDBContext>();;

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DBContext>
    (options =>
                options.UseSqlServer(
                 builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAuthentication()
    .AddGoogle(googleOptions =>
{
    googleOptions.ClientId = builder.Configuration["Authentication:Google:ClientId"];

    googleOptions.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"];

});


builder.Services.Configure<StripeConfig>(builder.Configuration.GetSection("Stripe"));


builder.Services.AddRazorPages();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<ILessonService, LessonService>();
builder.Services.AddScoped<IAssignmentService, AssignmentService>();
builder.Services.AddScoped<IDbInitializer, DbInitializer>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
   // app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

SeedData();
StripeConfiguration.ApiKey = "sk_test_51L2L91Je1w6gf5udKG8FV71gjjPOPuciJ475YrBYPmCHi6dm4vGTF3e0A9Kdpojod6jdoX88VnuI4nZsW03tFXme00zsMZWh0T";
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}",
    app.MapRazorPages()
    );

app.Run();

void SeedData()
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = app.Services.CreateScope())
    {
        var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
        dbInitializer.Seed();
    }
}