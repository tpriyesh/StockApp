using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Stock.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Dashboard", "dashboard",
                            new { controller = "Dashboard", action = "Index" });
            routes.MapRoute("Error404", "error404",
                            new { controller = "Error", action = "Index" });

            routes.MapRoute("Error500", "error500",
                            new { controller = "Error", action = "Error500" });
           
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Dashboard", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}