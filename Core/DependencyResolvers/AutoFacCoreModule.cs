﻿using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.InterCeptors;

namespace Core.DependencyResolvers
{
    public class AutoFacCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                    .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                    {
                        Selector = new AspectInterceptorSelector()
                    }).InstancePerDependency();
        }
    }
}