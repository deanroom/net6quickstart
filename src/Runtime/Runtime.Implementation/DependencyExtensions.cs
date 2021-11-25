using Microsoft.Extensions.DependencyInjection;
using Runtime.Abstractions;

namespace Runtime.Implementation
{
    public static class DependencyExtensions
    {
        public static IServiceCollection RegisterRuntime(this IServiceCollection services)
        {
            return services.AddScoped<IRuntime, RuntimeDemo>();
        }
    }
}