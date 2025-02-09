﻿using Mds.Blazor.Web.Services.Abstractions;
using Mds.Blazor.Web.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Mds.Blazor.Web.Services.Extensions;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddWebServices(this IServiceCollection services)
    {
        services.AddTransient<IUserService, UserService>();

        return services;
    }
}
