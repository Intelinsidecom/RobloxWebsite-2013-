using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Roblox.Web.Mvc;

namespace Roblox.Website.Controllers
{
    [CookieConstraintAttributeWithRedirect]
    [RoutePrefix("userads")]
    public class UserAdsController : Controller
    {
        // GET: UserAds
        [Route("{adType}")]
        public ActionResult Index(int adType)
        {
            return View();
        }
    }
}