using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Roblox.Website.Models.Request;

namespace Roblox.Website.Controllers
{
    [RoutePrefix("game")]
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            return View();
        }

        [Route("validate-machine")]
        [HttpPost]
        public JsonResult ValidateMachine(ValidateMachineRequest request)
        {
            return Json(new { success = true });
        }
    }
}
