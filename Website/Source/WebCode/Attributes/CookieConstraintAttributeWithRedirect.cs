using System;
using System.Web.Mvc;
using Roblox.Web.Code.CookieConstraint;

namespace Roblox.Website
{
    public class CookieConstraintAttributeWithRedirect : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Check if cookie constraint is enabled
            if (Roblox.Web.Code.Properties.Settings.Default.IsCookieConstraintEnabled)
            {
                // Check if the request has the required cookie
                if (!CookieConstraintValidator.HasConstrainedCookie(filterContext.HttpContext.Request))
                {
                    // Redirect to the cookie constraint page
                    filterContext.Result = new RedirectResult("/CookieConstraint");
                    return;
                }
            }
            
            base.OnActionExecuting(filterContext);
        }
    }
}
