using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProyectoWebApi.DesarrolloIntegral.Application.Database;
using ProyectoWebApi.DesarrolloIntegral.Persistence.Database;

namespace ProyectoWebApi.DesarrolloIntegral.Persistence
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DatabaseService>(options =>
            options.UseSqlServer(configuration["SQLConnectionString"]));

            services.AddScoped<IDatabaseService, DatabaseService>();

            return services;
        }
    }
}
