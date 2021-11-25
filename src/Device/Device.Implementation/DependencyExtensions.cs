using Device.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Runtime.Abstractions;
using Runtime.Implementation;

namespace Device.Implementation
{
    public static class DependencyExtensions
    {
        public static IServiceCollection RegisterDevice(this IServiceCollection services)
        {
            return services.AddScoped<IDevice, DeviceDemo>()
                .RegisterRuntime();
        }
    }
}