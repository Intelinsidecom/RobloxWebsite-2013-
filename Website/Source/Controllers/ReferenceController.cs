using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Roblox.Web.Mvc;

namespace Roblox.Website.Controllers
{
    [RoutePrefix("Reference")]
    [Route("{action}")]
    [CookieConstraintAttributeWithRedirect]
    public class ReferenceController : Controller
    {
        // GET: Reference/Blank
        public ActionResult Blank()
        {
            return View();
        }
    }
}