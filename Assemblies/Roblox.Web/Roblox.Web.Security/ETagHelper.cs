using System;
using System.Web;
using Roblox.Common;
using Roblox.Libraries.Cookies;
using Roblox.Web.Cookies;
using Roblox.Web.Properties;

namespace Roblox.Web.Security;

public class ETagHelper
{
	/// <summary>
	/// Set a cookie on the browser based off of the detected etag
	/// </summary>
	/// <param name="token">Etag Token Object</param>
	public static void SetCookie(EtagToken token)
	{
		EtagCookie orCreate = RobloxCookieHelper.GetOrCreate<EtagCookie>(EtagCookie.CookieIdentifier);
		orCreate.Etag = token.Encode();
		orCreate.Save();
	}

	/// <summary>
	/// Set the response headers on the image request to create the etag
	/// </summary>
	/// <param name="context">HttpContext of the request</param>
	/// <param name="token">Etag Token</param>
	public static void SetResponseHeader(HttpContextBase context, EtagToken token)
	{
		context.Response.Cache.SetETag(token.Encode());
		context.Response.Cache.SetCacheability(HttpCacheability.ServerAndPrivate);
	}

	/// <summary>
	/// Try to extract the ETAG from the cookie. If this fails the cookies were probably cleared or tampered
	/// </summary>
	/// <param name="token">Etag Token</param>
	/// <returns>If successfully retrieved etag from cookie</returns>
	public static bool TryGetFromCookie(out EtagToken token)
	{
		EtagCookie cookie = RobloxCookieHelper.Get<EtagCookie>(EtagCookie.CookieIdentifier);
		if (cookie != null && EtagToken.TryDecode(cookie.Etag, out var tempToken))
		{
			token = tempToken;
			return true;
		}
		token = null;
		return false;
	}

	/// <summary>
	/// Get the ETAG from an image request to the ETAG tracking endpoint
	/// </summary>
	/// <param name="context">Current Context</param>
	/// <param name="token">Etag Token</param>
	/// <returns>If etag token was extracted from request</returns>
	public static bool TryGetFromRequest(HttpContextBase context, out EtagToken token)
	{
		string etag = context.Request.Headers.Get("IF-NONE-MATCH");
		if (!string.IsNullOrWhiteSpace(etag) && EtagToken.TryDecode(etag, out var tempToken))
		{
			token = tempToken;
			return true;
		}
		token = null;
		return false;
	}

	/// <summary>
	/// Check to see if the ETag IP matches the current request IP. If they don't match it means the users
	/// IP address on their PC has changed since the last time the ETAG IP was updated based on the ETAG IP Expiry
	/// setting. Basically this is checking to see if the user is checking to see if they are changing their IP rapidly
	/// </summary>
	/// <param name="currentRequest">Current Request Context</param>
	/// <returns>True of the Etag IP matches the current request IP</returns>
	public static bool CheckEtagIpMatchesRequestIp(HttpContextBase currentRequest)
	{
		if (Settings.Default.EtagCheckIpMatch)
		{
			string currentRequestIp = currentRequest.GetOriginIP();
			if (TryGetFromCookie(out var token))
			{
				return token.IP.Equals(currentRequestIp);
			}
			return false;
		}
		return true;
	}

	/// <summary>
	/// Check to see if the embedded IP data of the Etag should be updated to the users newest IP
	/// based on if the expiry time has passed.
	/// </summary>
	/// <param name="context">Current Request Context</param>
	/// <param name="currentToken">The Etag token to check IP data</param>
	public static void CheckUpdateEtagIp(HttpContextBase context, EtagToken currentToken)
	{
		string currentIp = context.GetOriginIP();
		if (!string.Equals(currentToken.IP, currentIp) && DateTime.UtcNow - currentToken.Timestamp > Settings.Default.EtagIpExpiryTime)
		{
			currentToken.UpdateEtagIp(currentIp);
		}
	}

	/// <summary>
	/// Delete the ETAG cookie. The cookie isn't needed once the user creates an account or logs in and 
	/// since the cookie is moderately size ~200 bytes it is good performance to get rid of it
	/// </summary>
	public static void DeleteEtagCookie()
	{
		RobloxCookieHelper.Get<EtagCookie>(EtagCookie.CookieIdentifier)?.Delete();
	}
}
