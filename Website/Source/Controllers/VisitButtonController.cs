using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Roblox.Website.ViewModels.VisitButtons;

namespace Roblox.Website.Controllers
{
    [RoutePrefix("VisitButton")]
    [Route("{action}")]
    public class VisitButtonController : Controller
    {
        // GET: VisitButton/LaunchUniverse
        public ActionResult LaunchUniverse(VisitButtonModel model)
        {
            return View(model);
        }
    }
}