using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Roblox.Website
{
    // Reference: http://stackoverflow.com/a/1074061/626911
    public class RazorBridge
    {
        public class WebFormShimController : Controller { }

        public static void RenderPartial(string partialName)
        {
            RenderPartial(partialName, new object());
        }

        public static void RenderPartial(string partialName, object model)
        {
            // Get a wrapper for the legacy WebForm context
            var httpCtx = new HttpContextWrapper(System.Web.HttpContext.Current);

            // Create a mock route that points to the empty controller
            var rt = new RouteData();
            rt.Values.Add("controller", "WebFormShimController");

            // Create a controller context for the route and http context
            var ctx = new ControllerContext(
                new RequestContext(httpCtx, rt), new WebFormShimController());

            // Find the partial view using the viewengine
            var view = ViewEngines.Engines.FindPartialView(ctx, partialName).View;

            if (view == null)
                throw new Exception($"Couldn't find partial view: \"{partialName}\"");

            // Create a view context and assign the model
            var vctx = new ViewContext(ctx, view,
                new ViewDataDictionary { Model = model },
                new TempDataDictionary(), httpCtx.Response.Output);

            // Render the partial view
            view.Render(vctx, System.Web.HttpContext.Current.Response.Output);
        }
    }
}