using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Roblox.Website {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            // Ensure MVC handles extensionless URLs like /Landing/Animated and root '/'
            // Root path -> Landing/Animated
            routes.MapRoute(
                name: "Root",
                url: string.Empty,
                defaults: new { controller = "Landing", action = "Animated" }
            );
            routes.MapRoute(
                name: "LandingAnimated",
                url: "Landing/Animated",
                defaults: new { controller = "Landing", action = "Animated" }
            );

            routes.MapRoute(
                name: "FetchCSS",
                url: "CSS/Base/CSS/FetchCSS",
                defaults: new { controller = "ReplicatedCss", action = "GetFile" }
            );

            routes.MapRoute(
                name: "NewFetchCSS",
                url: "css/{path}/fetch",
                defaults: new { controller = "ReplicatedCss", action = "GetFile" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Landing", action = "Animated", id = UrlParameter.Optional }
            );
        }
    }
}
