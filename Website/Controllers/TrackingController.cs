using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Roblox.Web.Mvc;

namespace Roblox.Website.Controllers
{
    [RoutePrefix("Tracking")]
    [Route("{action}")]
    [CookieConstraintAttributeWithRedirect]
    public class TrackingController : Controller
    {
        // GET: Tracking/EventManager
        public ActionResult EventManager()
        {
            return View();
        }

        // GET: Tracking/GoogleAdWordsConversionTracker
        public ActionResult GoogleAdWordsConversionTracker()
        {
            return View();
        }

        // GET: Tracking/JavascriptErrorTracker
        public ActionResult JavascriptErrorTracker()
        {
            return View();
        }

        // GET: Tracking/VendorSpecificSignupTrackingPixel
        public ActionResult VendorSpecificSignupTrackingPixel()
        {
            return View();
        }
    }
}