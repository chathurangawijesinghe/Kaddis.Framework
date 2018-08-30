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
    using Kaddis.Framework.Common.Patterns.UnitOfWork;
    using Kaddis.Framework.DataServices.Admin;
    using Kaddis.Framework.DataServices.IAdmin;

    /// <summary>
    /// The services dependancy injection.
    /// </summary>
    public class RegisterDataServices
    {
        /// <summary>
        /// Register services.
        /// </summary>
        /// <param name="container">The container.</param>
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<ITestRepository, TestRepository>(new HierarchicalLifetimeManager());
        }
    }
}
