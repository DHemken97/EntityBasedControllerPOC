using ClassLibrary1;
using EntityBasedControllerPOC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EntityBasedControllerPOC
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            SqlRepository<User>.ConnectionString = "Data Source=localhost;Initial Catalog=Test;Integrated Security=True";

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
