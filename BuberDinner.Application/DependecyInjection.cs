using BuberDinner.Application.Services.Authentification;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Application;

public static class DependecyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthentificationServices, AuthentificationServices>();
        return services;
    }
}