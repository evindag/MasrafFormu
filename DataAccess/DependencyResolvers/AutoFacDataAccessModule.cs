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

            builder.RegisterType<MongoDB_FisDal>().As<IFisDal>().SingleInstance();
            builder.RegisterType<MongoDB_MakbuzDal>().As<IMakbuzDal>().SingleInstance();
            builder.RegisterType<MongoDB_PersonelDal>().As<IPersonelDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                       .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                       {
                           Selector = new AspectInterceptorSelector()
                       }).SingleInstance();

        }
    }
}
