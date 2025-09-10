using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Roblox.Website {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            // Allow MVC to process URLs that map to existing physical files or directories
            // This fixes scenarios where a physical directory (e.g. 'Landing') exists on disk, but we
            // still want routes like '/Landing/Animated' to be handled by MVC controllers.
            routes.RouteExistingFiles = true;

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

#if DEBUG
            // Debug-only utility endpoints
            routes.MapRoute(
                name: "Ping",
                url: "ping",
                defaults: new { controller = "Landing", action = "Ping" }
            );
            routes.MapRoute(
                name: "DebugLinks",
                url: "debug/links",
                defaults: new { controller = "Landing", action = "DebugLinks" }
            );
#endif

            // Ensure MVC handles extensionless URLs like /Landing/Animated and root '/'
            // Root path -> Landing/Animated
            routes.MapPageRoute(
                routeName: "RootDefault",
                routeUrl: string.Empty,
                physicalFile: "~/Default.aspx"
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
