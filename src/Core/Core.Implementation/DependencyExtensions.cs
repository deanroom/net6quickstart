using Core.Abstractions;
using Core.Implementation;
using Device.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Runtime.Abstractions;

namespace Core.Implementation
{
    public static class DependencyExtensions
    {
        public static IServiceCollection RegisterDevice(this IServiceCollection services)
        {
           return services.AddScoped<ICore, CoreDemo>()
                .RegisterDevice();
        }
    }
}