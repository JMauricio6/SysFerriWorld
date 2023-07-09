using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SysFerriWorld.Sales.DataAccess.Context;

namespace SysFerriWorld.Sales.IOC
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection GetConfigurationApplication(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(FerriWorldDbContext).Assembly.FullName;
            services.AddDbContext<FerriWorldDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DevCon"), b => b.MigrationsAssembly(assembly));
            }, ServiceLifetime.Transient);
            return services;
        }
    }
}
