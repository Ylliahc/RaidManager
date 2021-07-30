using System;
using Microsoft.Extensions.DependencyInjection;
using RaidManager.Infrastructure.Providers;

namespace RaidManager.Infrastructure.Extensions
{
    public static class InfrastructureServiceCollectionExtension
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IQueryProvider, QueryProvider>();
            return services;
        }
    }
}