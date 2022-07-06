using BuberDinner.Application.Common.Interfaces.Authentification;
using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Application.Common.Interfaces.Services;
using BuberDinner.Infrasctructure.Authentification;
using BuberDinner.Infrasctructure.Persistence;
using BuberDinner.Infrasctructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Infrasctructure;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        ConfigurationManager builderConfiguration)
    {
        services.Configure<JwtSettings>(builderConfiguration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator,JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        services.AddScoped<IUserRepository, UserRepository>(); 
        return services;
    }
}