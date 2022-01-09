using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASPNETMVCRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            

            routes.MapRoute("Blog", "blog/{year}/{month}/{day}",
                            new { Controller = "Blog", action = "Index" , day = UrlParameter.Optional},
                            new { year = @"\d{4}", month = @"\d{2}"}
            );

        }
    }
}
