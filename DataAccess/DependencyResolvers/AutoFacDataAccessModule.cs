using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.InterCeptors;
using DataAccess.Abstract;
using DataAccess.Concrete.MongoDB;

namespace DataAccess.DependencyResolvers
{
    public class AutoFacDataAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<MongoDB_ReceiptDal>().As<IReceiptDal>().SingleInstance();
            builder.RegisterType<MongoDB_CheckDal>().As<ICheckDal>().SingleInstance();
            builder.RegisterType<MongoDB_EmployeeDal>().As<IEmployeeDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                       .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                       {
                           Selector = new AspectInterceptorSelector()
                       }).SingleInstance();

        }
    }
}
