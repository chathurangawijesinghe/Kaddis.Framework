#region copyright
// -----------------------------------------------------------------------
// <copyright file="ApiAuthorizationException.cs" company="NCS Pte Ltd">
//      Copyright (c) NCS Pte Ltd. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
#endregion

namespace Kaddis.Framework.Core.DependencyInjection.Unity
{
    using global::Unity;
    using global::Unity.Lifetime;
    using Kaddis.Framework.Services.Admin;
    using Kaddis.Framework.Services.IAdmin;

    /// <summary>
    /// The services dependancy injection.
    /// </summary>
    public class RegisterServices
    {
        /// <summary>
        /// Register services.
        /// </summary>
        /// <param name="container">The container.</param>
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<ITestService, TestService>(new HierarchicalLifetimeManager());
        }
    }
}
