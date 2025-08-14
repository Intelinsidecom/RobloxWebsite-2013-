using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Roblox.Web.Mvc;

namespace Roblox.Website.Controllers
{
    [RoutePrefix("Home")]
    [CookieConstraintAttributeWithRedirect]
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            if (!Request.IsAuthenticated)
                return Redirect("~/Login");

            return View();
        }
    }
}