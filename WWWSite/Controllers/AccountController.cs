using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roblox.Website.Controllers
{
    [RoutePrefix("Account")]
    [Route("{action}")]
    public class AccountController : Controller
    {
        // GET: Account/SignupRedir
        public ActionResult SignupRedir(string month, string day, string year, string gender = "none")
        {
            if (Request.IsAuthenticated)
                return Redirect("/");

            var url = $"~/Login/Signup.aspx?yyyy={year}&mm={month}&dd={day}&gender={gender}";
            return Redirect(url);
        }
    }
}