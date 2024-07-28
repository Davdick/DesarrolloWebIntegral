using ProyectoWebAPI.DesarrolloIntegral.Api;
using ProyectoWebApi.DesarrolloIntegral.Common;
using ProyectoWebApi.DesarrolloIntegral.Application;
using ProyectoWebApi.DesarrolloIntegral.External;
using ProyectoWebApi.DesarrolloIntegral.Persistence;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

builder.Services
    .AddWebApi()
    .AddCommon()
    .AddApplication()
    .AddExternal(builder.Configuration)
    .AddPersistence(builder.Configuration);
builder.Services.AddControllers();

app.MapControllers();
app.Run();

