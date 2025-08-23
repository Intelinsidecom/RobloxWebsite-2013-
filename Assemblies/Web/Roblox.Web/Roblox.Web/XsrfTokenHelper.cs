using System;
using System.Net;
using System.Web;
using Roblox.Common;
using Roblox.Web.Properties;

namespace Roblox.Web;

public class XsrfTokenHelper
{
	public static HttpStatusCode BadTokenHttpStatusCode => HttpStatusCode.Forbidden;

	public static string TokenHeaderName => "X-CSRF-TOKEN";

	protected static bool XsrfTokenValidationEnabled => Settings.Default.XsrfTokenValidationEnabled;

	protected static TimeSpan XsrfTokenCacheExpiry => Settings.Default.XsrfTokenCacheExpiry;

	/// <summary>
	/// Event raised before validating xsrf.  Parameter to handler is the key.
	/// </summary>
	public static event Action<string> OnXsrfValidationRequest;

	/// <summary>
	/// Event raised after successfully validating xsrf using TOTP.  Parameter to handler is the key.
	/// </summary>
	public static event Action<string> OnXsrfTotpCheckPassed;

	/// <summary>
	/// Event raised if validating xsrf against TOTP calculation failed.  Parameter to handler is the key.
	/// </summary>
	public static event Action<string> OnXsrfTotpCheckFailed;

	public static string GetOrCreateToken(string key)
	{
		if (key == "XsrfSafeToken_Username_none")
		{
			return "";
		}
		return new TotpXsrfToken().GetTotpXsrfToken(key, DateTime.UtcNow, XsrfTokenCacheExpiry);
	}

	public static bool ValidateToken(string key, string value)
	{
		XsrfTokenHelper.OnXsrfValidationRequest?.Invoke(key);
		if (Settings.Default.OmittingXsrfTokenIsAlwaysInvalid && string.IsNullOrEmpty(value))
		{
			return false;
		}
		if (new TotpXsrfToken().ValidateTotpXsrfToken(key, value, DateTime.UtcNow, XsrfTokenCacheExpiry))
		{
			XsrfTokenHelper.OnXsrfTotpCheckPassed?.Invoke(key);
			return true;
		}
		XsrfTokenHelper.OnXsrfTotpCheckFailed?.Invoke(key);
		return false;
	}

	public static string GetXsrfSafeTokenKey(HttpContext context)
	{
		if (context.User.Identity.IsAuthenticated)
		{
			return "XsrfSafeToken_Username_" + HttpUtility.UrlEncode(context.User.Identity.Name);
		}
		return "XsrfSafeToken_IP_" + HttpUtility.UrlEncode(context.GetOriginIP());
	}

	public static bool RequestIsValid(HttpContext context)
	{
		string submittedToken = context.Request.Headers.Get(TokenHeaderName);
		string storedTokenKey = GetXsrfSafeTokenKey(context);
		if (XsrfTokenValidationEnabled && !ValidateToken(storedTokenKey, submittedToken))
		{
			HttpResponse response = context.Response;
			response.StatusCode = (int)BadTokenHttpStatusCode;
			response.StatusDescription = "Token Validation Failed";
			string token = GetOrCreateToken(storedTokenKey);
			response.Headers.Add(TokenHeaderName, token);
			if (Settings.Default.XsrfOnHandlerIgnoresIisCustomErrors)
			{
				response.TrySkipIisCustomErrors = true;
			}
			return false;
		}
		return true;
	}
}
