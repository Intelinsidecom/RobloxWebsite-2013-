using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Roblox.Web.Mvc;
using Roblox.Website.WebCode;

namespace Roblox.Website.Controllers
{
    [RoutePrefix("Landing")]
    [Route("{action}")]
    [CookieConstraintAttributeWithRedirect]
    public class LandingController : Controller
    {
        private SignupHelper _helper;

        public LandingController()
        {
            _helper = new SignupHelper(System.Globalization.CultureInfo.CurrentUICulture);
        }

        // GET: Landing/Animated
        public ActionResult Animated()
        {
            if (Request.IsAuthenticated)
                return Redirect("/");

            ViewBag.IsAnimated = true;
            ViewBag.MonthSelectList = new SelectList(_helper.GetMonths(), "Key", "Value");
            ViewBag.DaySelectList = new SelectList(_helper.GetDays(), "Key", "Value");
            ViewBag.YearSelectList = new SelectList(_helper.GetYears(), "Key", "Value");

            return View();
        }

        // POST: Landing/Animated
        [HttpPost]
        public ActionResult Animated(FormCollection form)
        {
            var gender = (byte)(form["gender"] == "Female" ? 2 : 1);

            var status = _helper.DoSignup(form["lstDays"], form["lstMonths"], form["lstYears"],
            gender, form["username"], form["password"], form["passwordConfirm"]);

            return Redirect(_helper.GetRedirectUrlForSignupStatus(status));
        }
    }
}