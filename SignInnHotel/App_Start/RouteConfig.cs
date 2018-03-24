using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SignInnHotel
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Home",
               url: "Hotel-Sign-Inn",
               defaults: new { controller = "Home", action = "Index" }
           );
            routes.MapRoute(
              name: "ContactUS",
              url: "Contact-Us",
              defaults: new { controller = "Home", action = "ContactUs" }
          );
            routes.MapRoute(
              name: "AboutUs",
              url: "About-Us",
              defaults: new { controller = "Home", action = "AboutUs" }
          );
            routes.MapRoute(
             name: "Gallery",
             url: "Gallery",
             defaults: new { controller = "Home", action = "Gallery" }
         );
            routes.MapRoute(
            name: "RoomeDetils",
            url: "Roome-Details",
            defaults: new { controller = "Home", action = "RoomeDetails" }
        );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
