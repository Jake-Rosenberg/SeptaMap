using Microsoft.Extensions.DependencyInjection;
using Refit;
using SeptaMap.Infrastructure.External.Interfaces;
using SeptaMap.Infrastructure.External.Services;

namespace SeptaMap.Infrastructure.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string septaApiBaseUrl)
        {
            services.AddRefitClient<ISeptaApi>()
                    .ConfigureHttpClient(c => c.BaseAddress = new Uri(septaApiBaseUrl));

            services.AddScoped<TrainViewService>();

            return services;
        }
    }
}
