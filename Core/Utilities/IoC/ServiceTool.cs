using Autofac;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;

namespace Core.Utilities.IoC
{
    public static class ServiceTool
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        public static IServiceCollection Services { get; private set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
                    //CreateForMicrosoftDependencies
                    // Services = services;
            


            ServiceProvider = services.BuildServiceProvider();
            return services;
        }

    }
}
