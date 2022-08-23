using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace Core.DependencyResolvers
{
    public class CoreModule : IDependencyInjectionModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddMemoryCache();

            services.AddSingleton<Stopwatch>();
        }

    }
}

