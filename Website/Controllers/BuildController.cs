using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Roblox.Web.Mvc;

namespace Roblox.Website.Controllers
{
    [RoutePrefix("Build")]
    [CookieConstraintAttributeWithRedirect]
    public class BuildController : Controller
    {
        // GET: Build
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        /* Ads(Int32 startRow, Nullable<int> groupId) */
    }
}