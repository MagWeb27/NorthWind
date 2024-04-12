using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyContainer
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddDebugWriter();
        services.AddServices();
        return services;
    }
}
