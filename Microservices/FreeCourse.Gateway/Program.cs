<<<<<<< HEAD
using FreeCourse.Gateway.DelegateHandlers;
=======
>>>>>>> main
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication().AddJwtBearer("GatewayAuthenticationScheme", options =>
{
    options.Authority = builder.Configuration["IdentityServerURL"];
    options.Audience = "resource_gateway";
    options.RequireHttpsMetadata = false;
});

<<<<<<< HEAD
builder.Services.AddHttpClient<TokenExhangeDelegateHandler>();
builder.Services.AddOcelot().AddDelegatingHandler<TokenExhangeDelegateHandler>();
=======
builder.Services.AddOcelot();
>>>>>>> main

var app = builder.Build();
var env = builder.Environment;
builder.Configuration.AddJsonFile($"configuration.{env.EnvironmentName.ToLower()}.json").AddEnvironmentVariables();

app.MapGet(" /", () => "Hello World!");
await app.UseOcelot();
app.Run();