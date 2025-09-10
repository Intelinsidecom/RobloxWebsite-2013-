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
                if (!CookieConstraintValidator.HasConstrainedCookie(System.Web.HttpContext.Current.Request))
                {
                    // Redirect to an existing page that instructs users how to fulfill the constraint
                    filterContext.Result = new RedirectResult("/Login/FulfillConstraint.aspx");
                    return;
                }
            }
            
            base.OnActionExecuting(filterContext);
        }
    }
}
