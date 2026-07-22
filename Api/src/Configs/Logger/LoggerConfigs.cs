using Serilog;

namespace Api.src.Configs.Logger;

public static class LoggerConfigs
{
    public static void ConfigureLogger(WebApplicationBuilder builder)
    {
        builder.Host.UseSerilog((context, services, configuration) => configuration
            .ReadFrom.Configuration(context.Configuration)
            .Enrich.FromLogContext()
            .Enrich.WithEnvironmentName()
            .Enrich.WithMachineName()
            .Enrich.WithProcessId()
            .Enrich.WithThreadId()
            .Enrich.FromLogContext()
        );

        builder.Logging.ClearProviders();
    }
}
