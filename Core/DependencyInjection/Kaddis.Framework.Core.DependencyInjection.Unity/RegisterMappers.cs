using Kaddis.Framework.Common.Mappers.Admin;
using Unity;
using Unity.Lifetime;

namespace Kaddis.Framework.Core.DependencyInjection.Unity
{
    public class RegisterMappers
    {
        /// <summary>
        /// Register mappers.
        /// </summary>
        /// <param name="container">The container.</param>
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<ITestMapper, TestMapper>(new HierarchicalLifetimeManager());
        }
    }
}
