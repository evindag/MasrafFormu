using Core.Utilities.IoC;
using DataAccess.Abstract;
using DataAccess.Concrete.Databases.MongoDB;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.DependencyResolvers
{
    public class DataAccessModule : IDependencyInjectionModule
    {
        public void Load(IServiceCollection services)
        {
 
        }
    }
}
