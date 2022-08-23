using Autofac;
using Autofac.Extras.DynamicProxy;
using Businnes.Abstract;
using Businnes.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.InterCeptors;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            builder.RegisterType<FisYonetimi>().As<IFisService>().SingleInstance();
            builder.RegisterType<MakbuzYonetimi>().As<IMakbuzService>().SingleInstance();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                       .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                       {
                           Selector = new AspectInterceptorSelector()
                       }).SingleInstance();

        }
    }
}
