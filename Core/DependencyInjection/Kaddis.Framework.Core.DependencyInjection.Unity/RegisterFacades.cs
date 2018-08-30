using Kaddis.Framework.Facades.Common;
using Kaddis.Framework.Facades.ICommon;
using Unity;
using Unity.Lifetime;

namespace Kaddis.Framework.Core.DependencyInjection.Unity
{
    public class RegisterFacades
    {
        /// <summary>
        /// Register facades.
        /// </summary>
        /// <param name="container">The container.</param>
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<ITestFacade, TestFacade>(new HierarchicalLifetimeManager());
        }
    }
}
