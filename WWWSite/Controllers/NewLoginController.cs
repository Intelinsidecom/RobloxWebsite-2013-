using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Roblox.Platform.Membership;
using Roblox.Web.Mvc;
using Roblox.Website.ViewModels;

namespace Roblox.Website.Controllers
{
    [RoutePrefix("NewLogin")]
    public class NewLoginController : Controller
    {
        private void SetErrorMessage(string message)
        {
            if (!string.IsNullOrEmpty(message))
                ModelState.AddModelError("ErrorMessage", message);
        }

        // GET: NewLogin
        [Route("")]
        public ActionResult Index(string returnUrl = "/")
        {
            if (Request.IsAuthenticated)
            {
                return Redirect("~/");
            }

            var viewModel = new LoginViewModel
            {
                ReturnUrl = returnUrl
            };

            return View(viewModel);
        }

        // POST: NewLogin
        [Route("")]
        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {
            if (!Request.IsAuthenticated)
            {
                SetErrorMessage(model.GetValidationMessage());

                if (ModelState.IsValid)
                {
                    if (Membership.ValidateUser(model.Username, model.Password))
                    {
                        // We've been able to validate the user's auth request, now authenticate and redirect
                        FormsAuthentication.SetAuthCookie(model.Username, true);
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        // Incorrect username or password
                        SetErrorMessage("Incorrect username or password");
                    }
                }
                else
                {
                    // Unknown user
                    SetErrorMessage("Unknown user");
                }
                return View(model);
            }

            return Redirect(model.ReturnUrl);
        }
    }
}