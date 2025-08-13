using System.Linq;
using System.Web;

namespace Roblox.Libraries.Cookies;

public static class RobloxCookieHelper
{
	/// <summary>
	/// Gets a cookie by name in the current HttpContext
	/// First by checking the Response object to see the cookie is already being written in another function.
	/// Then it checks for existing cookie in the Request object.
	/// No, it doesn't!
	/// </summary>
	/// <param name="name">name of the cookie</param>
	/// <returns>An existing cookie from the Response or Request object, or null if none</returns>
	private static HttpCookie _GetHttpCookieByName(string name)
	{
		HttpContext context = HttpContext.Current;
		string[] allResponseCookieKeys = context?.Response.Cookies.AllKeys;
		if (allResponseCookieKeys != null && allResponseCookieKeys.Contains(name))
		{
			HttpCookie cookie = context.Response.Cookies[name];
			if (cookie == null || cookie.Value == null)
			{
				return null;
			}
			return cookie;
		}
		string[] allRequestCookieKeys = context?.Request.Cookies.AllKeys;
		if (allRequestCookieKeys != null && allRequestCookieKeys.Contains(name))
		{
			return context.Request.Cookies[name];
		}
		return null;
	}

	public static T Get<T>(RobloxCookieIdentifier cookieIdentifier) where T : RobloxCookieBase, new()
	{
		HttpCookie httpCookie = _GetHttpCookieByName(cookieIdentifier.Name);
		if (httpCookie == null || string.IsNullOrEmpty(httpCookie.Value))
		{
			return null;
		}
		T val = new T();
		val.DeSerializeValues(httpCookie.Values);
		val.Path = httpCookie.Path;
		val.Domain = httpCookie.Domain;
		val.HttpOnly = httpCookie.HttpOnly;
		return val;
	}

	public static T GetOrCreate<T>(RobloxCookieIdentifier cookieIdentifier) where T : RobloxCookieBase, new()
	{
		HttpCookie httpCookie = _GetHttpCookieByName(cookieIdentifier.Name);
		if (httpCookie == null || string.IsNullOrEmpty(httpCookie.Value))
		{
			return new T();
		}
		T val = new T();
		val.DeSerializeValues(httpCookie.Values);
		val.Path = httpCookie.Path;
		val.Domain = httpCookie.Domain;
		val.HttpOnly = httpCookie.HttpOnly;
		return val;
	}
}
