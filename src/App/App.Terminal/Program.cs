using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Core.Abstractions;
using Core.Implementation;
using Device.Abstractions;
using Device.Implementation;
using Framework.Abstractions;
using Framework.Implementations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Runtime.Abstractions;
using Runtime.Implementation;

namespace App.Terminal
{
    class Program
    {
        static Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();

            DoSomethingYouLike(host.Services);
            return host.RunAsync();
        }

        static void DoSomethingYouLike(IServiceProvider services)
        {
            using var serviceScope = services.CreateScope();
            var provider = serviceScope.ServiceProvider;
            var core = provider.GetRequiredService<ICore>();
            core.Start();
            core.Do("你好，车床.");
            core.Stop();
            var mutext = new Mutex(true, "GolbalMutext", out var createNew);
            if(!createNew)
                mutext.ReleaseMutex();

        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddConsole();
                })
                .ConfigureServices((_, services) =>
                    services
                        .AddScoped<ICore, CoreDemo2>()
                        .AddScoped<IDevice, DeviceDemo>()
                        .AddScoped<IRuntime, RuntimeDemo>()
                        .AddScoped<IFramework, FrameworkDemo>());
    }
}