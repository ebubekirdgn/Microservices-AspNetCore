using FreeCourse.Web.Models;
using FreeCourse.Web.Services.UserService;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<ClientSettings>(builder.Configuration.GetSection(ClientSettings.Option));
builder.Services.Configure<ServiceApiOptions>(builder.Configuration.GetSection(ServiceApiOptions.Option));
builder.Services.AddHttpContextAccessor();

var serviceApiOptions = builder.Configuration.GetSection(ServiceApiOptions.Option).Get<ServiceApiOptions>();

builder.Services.AddHttpClient<IUserService, UserService>(opt =>
{
    opt.BaseAddress = new Uri(serviceApiOptions.IdentityBaseUri);
});
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, opts =>
{
    opts.LoginPath = "/Auth/SignIn";
    opts.ExpireTimeSpan = TimeSpan.FromDays(60);
    opts.SlidingExpiration = true;
    opts.Cookie.Name = "udemywebcookie";
});
builder.Services.AddControllersWithViews();

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