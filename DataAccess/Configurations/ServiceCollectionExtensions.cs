using DataAccess.Implementations;

namespace DataAccess.Configurations
{
    using DataAccess.Abstractions;

    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceCollectionExtensios
    {
        public static void AddDataAccess(this IServiceCollection services, string connectionString)
        {
            //services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IRepository, Repository>();
        }
    }
}