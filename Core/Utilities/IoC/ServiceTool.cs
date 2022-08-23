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
  
        public static IServiceCollection CreateForMicrosoftDependencies(IServiceCollection services)
        {

            Services = services;
            ServiceProvider = services.BuildServiceProvider();


    
            return services;
        }

   
  
    }
}
