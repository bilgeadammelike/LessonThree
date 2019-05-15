using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LessonThree
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();


            config.Routes.MapHttpRoute(
            name: "Root",
            routeTemplate: "api/root/{id}",
            defaults: new { controller = "customer", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Default_Api",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

        }
    }
}
