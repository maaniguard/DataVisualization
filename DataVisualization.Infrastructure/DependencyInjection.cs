using DataVisualization.Core.Interfaces;
using DataVisualization.Infrastructure.Data;
using DataVisualization.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataVisualization.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ISalesDataRepository, SalesDataRepository>();

            return services;
        }
    }
}