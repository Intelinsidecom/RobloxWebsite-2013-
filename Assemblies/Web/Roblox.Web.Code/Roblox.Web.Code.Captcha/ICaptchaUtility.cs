using System.Web;
using Roblox.Platform.Captcha;
using Roblox.Platform.Marketing;
using Roblox.Platform.Membership;

namespace Roblox.Web.Code.Captcha;

public interface ICaptchaUtility
{
	CaptchaVerifier GetCaptchaVerifier(IUser authenticatedUser, RequestType requestType);

	bool IsCaptchaOnRequestEnabled(RequestType requestType);

	bool IsInApp(IBrowserTracker browserTracker, HttpContext httpContext);
}
