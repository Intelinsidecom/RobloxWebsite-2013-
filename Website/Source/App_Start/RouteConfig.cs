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

            /*routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );*/

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

            /*routes.MapRoute(
                name: "DefaultView",
                url: "{folder}/{view}",
                defaults: new { controller = "Default", action = "FetchView", view = UrlParameter.Optional }
            );*/
        }
    }
}
