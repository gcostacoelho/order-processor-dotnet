using Api.src.Configs.Db;
using Api.src.Models.Settings;
using Microsoft.EntityFrameworkCore;

namespace Api.src.Configs;

public static class DependencyInjectionsConfig
{
    public static void RegisterServices(this IServiceCollection services)
    {
    }

    public static void RegisterRepositories(this IServiceCollection services)
    {
    }

    public static void RegisterSingletons(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton(configuration.Get<AppSettings>());
    }

    public static void RegisterDatabaseConnection(this IServiceCollection services, IConfiguration configuration)
    {
        var appSettings = configuration.Get<AppSettings>();
        var connectionString = appSettings.Database.ConnectionString;
        services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));
    }
}
