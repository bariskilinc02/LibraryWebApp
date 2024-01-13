using Library.Data.Context;
using Microsoft.EntityFrameworkCore;
using Library.Data.Extensions;
using Library.Service.Extensions;
using Library.Entity.Entities;
using Microsoft.AspNetCore.Identity;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.LoadDataLayerExtension(builder.Configuration);
builder.Services.LoadServiceLayerExtension();
builder.Services.AddSession();



builder.Services.AddIdentity<AppUser, AppRole>(opt =>
{
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequireUppercase = false;
    opt.Password.RequireLowercase = false;
})
.AddRoleManager<RoleManager<AppRole>>()
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(userConfig =>
{
    //userConfig.LoginPath = new PathString("/User/Auth/Login");
    //userConfig.LogoutPath = new PathString("/User/Auth/Logout");
    userConfig.Cookie = new CookieBuilder
    {
        Name = "UserLibrary",
        HttpOnly = true,
        SameSite = SameSiteMode.Strict,
        SecurePolicy = CookieSecurePolicy.SameAsRequest
    };
    userConfig.SlidingExpiration = true;
    userConfig.ExpireTimeSpan = TimeSpan.FromDays(7);
    userConfig.AccessDeniedPath = new PathString("/User/Auth/AccessDenied");
});



// Add services to the container.
builder.Services.AddControllersWithViews();
// Add sql databse connection
//builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();
app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name:"Admin",
        areaName:"Admin",
        pattern:"Admin/{controller=Home}/{action=Index}/{id?}"


        );

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    //endpoints.MapDefaultControllerRoute();

});

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
