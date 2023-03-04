using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOcelot();


var app = builder.Build();
var env = builder.Environment;
builder.Configuration.AddJsonFile($"configuration.{env.EnvironmentName.ToLower()}.json").AddEnvironmentVariables();


app.MapGet(" /", () => "Hello World!");
await app.UseOcelot();
app.Run();