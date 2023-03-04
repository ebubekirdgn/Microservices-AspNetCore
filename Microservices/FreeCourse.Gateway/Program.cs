using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOcelot();


var app = builder.Build();

builder.Configuration.AddJsonFile($"appsettings{Environment.GetEnvironmentVariable(
"ASPNETCORE_ENVIRONMENT".ToLower())}.json", false, true);


app.MapGet(" /", () => "Hello World!");
await app.UseOcelot();
app.Run();