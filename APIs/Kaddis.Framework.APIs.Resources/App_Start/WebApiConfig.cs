using Kaddis.Framework.Core.DependencyInjection.Unity;
using Microsoft.Web.Http.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Routing;
using Unity;

namespace Kaddis.Framework.APIs.Resources
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //// Web API configuration and services
            var container = new UnityContainer();
            RegisterDataServices.Register(container);
            RegisterMappers.Register(container);
            RegisterServices.Register(container);
            RegisterFacades.Register(container);
            config.DependencyResolver = new UnityResolver(container);

            config.AddApiVersioning(v => v.AssumeDefaultVersionWhenUnspecified = true);

            // Web API routes
            var constraintResolver = new DefaultInlineConstraintResolver()
            {
                ConstraintMap = { ["apiVersion"] = typeof(ApiVersionRouteConstraint) }
            };

            // Web API routes
            config.MapHttpAttributeRoutes(constraintResolver);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
