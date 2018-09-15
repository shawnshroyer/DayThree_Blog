using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DayThree_Blog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "DetailSlug",
                url: "Blog/{slug}",
                defaults: new
                {
                    Controller = "BlogPosts",
                    action="Details",
                    slug = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "EditSlug",
                url: "Edit/{slug}",
                defaults: new
                {
                    Controller = "BlogPosts",
                    action = "Edit",
                    slug = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                defaults: new { controller = "BlogPosts", action = "Index", id = UrlParameter.Optional }

            );
        }
    }
}
