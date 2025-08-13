using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Web.Security;

namespace Roblox.Website.Services.Secure
{
    /// <summary>
    /// Summary description for LoginService
    /// </summary>
    [WebService(Namespace = "http://roblox.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class LoginService : System.Web.Services.WebService
    {
        public enum ErrorCodeEnum
        {
            None,
            ChallengeOrResponseMissing,
            UnableToVerifyCaptcha,
            ErrorOccurred,
            RequireTwoFactorAuth,
            FeatureDisabled,
            CaptchaChanged,
            IncorrectCredential,
            CaptchaValidation
        }

        public class LoginResponse
        {
            public bool IsValid { get; set; }
            public List<string> ErrorCode { get; set; }
            public string Message { get; set; }

            public LoginResponse()
            {
                ErrorCode = new List<string>();
            }

            public void ThrowError(ErrorCodeEnum code)
            {
                ErrorCode.Add(((int)code).ToString());
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public LoginResponse ValidateLogin(string userName, string password, bool isCaptchaOn = false, string challenge = "", string captchaResponse = "")
        {
            var loginResponse = new LoginResponse();

            if (Membership.ValidateUser(userName, password))
            {
                FormsAuthentication.SetAuthCookie(userName, true);
                loginResponse.IsValid = true;
                loginResponse.Message = String.Format("Welcome {0} to ROBLOX!", userName);
            }
            else
            {
                loginResponse.IsValid = false;
                loginResponse.ThrowError(ErrorCodeEnum.IncorrectCredential);
                loginResponse.Message = "Invalid username or password.";
            }

            return loginResponse;
        }
    }
}
