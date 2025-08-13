using System;
using System.Net;
using System.Web.Mvc;
using Newtonsoft.Json;
using Roblox.Platform.Captcha.Properties;
using Roblox.Web.Code.Properties;

namespace Roblox.Web.Code.Captcha;

public class RobloxRecaptchaValidatorAttribute : ActionFilterAttribute
{
	private const string _ChallengeFieldKey = "recaptcha_challenge_field";

	private const string _ResponseFieldKey = "recaptcha_response_field";

	private const string _ResponseFieldKeyV2 = "g-Recaptcha-Response";

	private const string _InvalidRecaptchaVersionReason = "InvalidRecaptchaVersion";

	public bool ForceCaptchaV2 { get; set; }

	public string CaptchaActionType { get; set; }

	public override void OnActionExecuting(ActionExecutingContext filterContext)
	{
		filterContext.ActionParameters["captchaValid"] = null;
		string v2Response = ((ControllerContext)filterContext).HttpContext.Request.Form["g-Recaptcha-Response"];
		bool isTrulyInvisible = ((ControllerContext)filterContext).HttpContext.Request.Form["isTrulyInvisible"] == "true";
		if (!string.IsNullOrEmpty(((ControllerContext)filterContext).HttpContext.Request.Form["fcToken"]))
		{
			filterContext.ActionParameters["captchaValid"] = false;
		}
		else if (Roblox.Web.Code.Properties.Settings.Default.UseRecaptchaV2 && IsRecaptchaEnabledForCaptchaActionType() && !string.IsNullOrEmpty(v2Response))
		{
			try
			{
				using WebClient wc = new WebClient();
				string recaptchaKey = Roblox.Web.Code.Properties.Settings.Default.GoogleInvisibleRecaptchaPrivateKey;
				if (isTrulyInvisible)
				{
					recaptchaKey = Roblox.Platform.Captcha.Properties.Settings.Default.GoogleTrulyInvisibleCaptchaPrivateKey;
				}
				string url = $"https://www.google.com/recaptcha/api/siteverify?secret={recaptchaKey}&response={v2Response}";
				RecaptchaResponseJsonModel response = JsonConvert.DeserializeObject<RecaptchaResponseJsonModel>(wc.DownloadString(url));
				filterContext.ActionParameters["captchaValid"] = response.Success;
				if (isTrulyInvisible)
				{
					filterContext.ActionParameters["score"] = response.Score;
					filterContext.ActionParameters["skipFloodcheck"] = true;
				}
			}
			catch (Exception ex)
			{
				ExceptionHandler.LogException(ex);
				if (Roblox.Web.Code.Properties.Settings.Default.ForcePassOnRecaptchaServerFailure)
				{
					filterContext.ActionParameters["captchaValid"] = true;
				}
			}
		}
		((ActionFilterAttribute)this).OnActionExecuting(filterContext);
	}

	private bool IsRecaptchaEnabledForCaptchaActionType()
	{
		return CaptchaActionType switch
		{
			"Signup" => Roblox.Web.Code.Properties.Settings.Default.RecaptchaEnabledForSignup, 
			"Login" => Roblox.Web.Code.Properties.Settings.Default.RecaptchaEnabledForLogin, 
			"UserAction" => Roblox.Web.Code.Properties.Settings.Default.RecaptchaEnabledForUserAction, 
			_ => true, 
		};
	}
}
