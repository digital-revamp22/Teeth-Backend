using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Teeth.Application.Interfaces;

namespace Teeth.Application;

public static class TeethApplicationModule
{
    public static IServiceCollection ConfigureTeethApplication(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddMediatR(c => c.RegisterServicesFromAssembly(typeof(TeethApplicationModule).Assembly));

        return services;
    }
    private static IServiceCollection AddRequestHandlers(this IServiceCollection services, Assembly assembly)
    {
        var handlerTypes = assembly.GetTypes()
            .Where(t => t.GetInterfaces()
                .Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IRequestHandler<,>)))
            .ToList();

        foreach (var handlerType in handlerTypes)
        {
            var handlerInterface = handlerType.GetInterfaces()
                .First(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IRequestHandler<,>));
            services.AddScoped(handlerInterface, handlerType);
        }

        return services;
    }
}