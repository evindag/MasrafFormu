using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.InterCeptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.MongoDB;
using Microsoft.AspNetCore.Http;

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

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<MongoDB_UserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                       .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                       {
                           Selector = new AspectInterceptorSelector()
                       }).SingleInstance();

        }
    }
}
