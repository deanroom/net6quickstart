using Framework.Abstractions;
using Framework.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Framework.Implementation
{
    public static class DependencyExtensions
    {
        public static IServiceCollection RegisterFramework(this IServiceCollection services)
        {
            return services.AddScoped<IFramework, FrameworkDemo>();
        }
    }
}