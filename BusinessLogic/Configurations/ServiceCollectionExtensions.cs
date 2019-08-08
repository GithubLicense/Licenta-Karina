namespace BusinessLogic.Configurations
{
    using DataAccess.Configurations;

    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceCollectionExtensions
    {
        public static void AddBusinessLogic(this IServiceCollection services, string connectionString)
        {
            services.AddDataAccess(connectionString);
            //services.AddScoped<IUserLogic, UserLogic>();
        }
    }
}
