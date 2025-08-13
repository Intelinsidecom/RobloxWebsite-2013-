using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using Roblox.Web.Mvc;

namespace Roblox.Website.Controllers
{
    [RoutePrefix("Authentication")]
    [Route("{action}")]
    [CookieConstraintAttributeWithRedirect]
    public class AuthenticationController : Controller
    {
        // GET: Authentication/Logout
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/");
        }
    }
}