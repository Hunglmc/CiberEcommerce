using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ciber.Application.Common.Interfaces;

namespace Ciber.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CiberDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("CiberEcommereDatabase")));

            services.AddScoped<ICiberDbContext>(provider => provider.GetService<CiberDbContext>());

            return services;
        }
    }
}