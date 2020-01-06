using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FIRST_ASP_NET_APPLICATION
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
              name: "Sinup",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Sinup", action = "Register", id = UrlParameter.Optional }
          );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Employee",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Employee", action = "Edit", id = UrlParameter.Optional }
           );
            routes.MapRoute(
             name: "Sinup",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Sinup", action = "Index", id = UrlParameter.Optional }
         );

        }
    }
}
