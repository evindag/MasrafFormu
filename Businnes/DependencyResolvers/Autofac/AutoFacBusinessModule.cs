using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.InterCeptors;
using DataAccess.Abstract;
using DataAccess.Concrete.MongoDB;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            builder.RegisterType<ReceiptManager>().As<IReceiptService>().SingleInstance();
            builder.RegisterType<MongoDB_ReceiptDal>().As<IReceiptDal>().SingleInstance();
            builder.RegisterType<CheckManager>().As<ICheckService>().SingleInstance();
            builder.RegisterType<MongoDB_CheckDal>().As<ICheckDal>().SingleInstance();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                       .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                       {
                           Selector = new AspectInterceptorSelector()
                       }).SingleInstance();

        }
    }
}
