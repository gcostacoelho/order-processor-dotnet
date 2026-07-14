using Api.src.Models.Settings;

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
}
