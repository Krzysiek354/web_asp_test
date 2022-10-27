using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });

                routes.MapRoute(
                name: "klient",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "klient", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "model",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "model", action = "model", id = UrlParameter.Optional });
        }
    }
}
