﻿using BuberDinner.Api.Common.Errors;
using BuberDinner.Api.Common.Mapping;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace BuberDinner.Api;

public static class DependecyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, BuberDinnerProblemDetailsFactory>();
        services.AddMapping();
        return services;
    }
}