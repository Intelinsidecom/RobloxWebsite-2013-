using System;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;
using System.Collections.Generic;
using Roblox.Platform.Membership;
using Roblox;

namespace Roblox.Website.Controllers
{
    [RoutePrefix("UserCheck")]
    [Route("{action}")]
    [CookieConstraintAttributeWithRedirect]
    public class UserCheckController : Controller
    {
        private readonly IUserFactory _userFactory = Global.MembershipDomainFactories.UserFactory;

        // UserCheck/CheckIfEmailIsBlacklisted
        public JsonResult CheckIfEmailIsBlacklisted(string email)
        {
            var success = false;
            if (!string.IsNullOrWhiteSpace(email))
            {
                // Use the existing Roblox BLL (from referenced DLLs) to check if email is blacklisted
                var entity = Roblox.EmailAddress.Get(email);
                success = entity != null && entity.IsBlacklisted;
            }

            return Json(
                new { success = success },
                JsonRequestBehavior.AllowGet
            );
        }

        // UserCheck/CheckIfInvalidUserNameForSignup
        public ActionResult CheckIfInvalidUserNameForSignup(string username)
        {
            byte result = 0;
            if (_userFactory.GetUserByName(username) != null)
                result = 1;
            else if (!Signup.ValidateUserName(username))
                result = 2;

            return Json(
                new { data = result },
                JsonRequestBehavior.AllowGet
            );
        }

        // UserCheck/DoesUsernameExist
        public ActionResult DoesUsernameExist(string username)
        {
            var account = _userFactory.GetUserByName(username);

            return Json(
                new { success = account != null },
                JsonRequestBehavior.AllowGet
            );
        }
        
        public ActionResult GetRecommendedUsername(string usernameToTry)
        {
            return new HttpStatusCodeResult(HttpStatusCode.NotImplemented);
        }
        
        public ActionResult GetSocialNetworkUserName(byte socialNetworkTypeId, string sessionData)
        {
            return new HttpStatusCodeResult(HttpStatusCode.NotImplemented);
        }
        
        public ActionResult GetSocialNetworkUserNameBySocialNetworkId(byte socialNetworkTypeId, string sessionData, int socialNetworkId)
        {
            return new HttpStatusCodeResult(HttpStatusCode.NotImplemented);
        }
        
        public ActionResult UpdatePersonalInfo(byte genderId, int birthYear, int birthMonth, int birthDay)
        {
            return new HttpStatusCodeResult(HttpStatusCode.NotImplemented);
        }
        
        public ActionResult ValidatePasswordForSignup(string username, string password)
        {
            return new HttpStatusCodeResult(HttpStatusCode.NotImplemented);
        }
    }
}
