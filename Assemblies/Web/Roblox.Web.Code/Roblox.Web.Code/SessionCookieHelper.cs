using System;
using System.Web;
using System.Web.Mvc;
using Roblox.Configuration;
using Roblox.Platform.Membership;
using Roblox.Web.Code.Events;
using Roblox.Web.Code.Properties;
using Roblox.Web.Cookies;
using Roblox.Web.Properties;

namespace Roblox.Web.Code;

public static class SessionCookieHelper
{
	public static void WebSessionPing(long userId, byte platformTypeId, IUserFactory userFactory, bool isSignupSession = false, ActionDescriptor actionDescriptor = null)
	{
		if (!Roblox.Web.Code.Properties.Settings.Default.UseWebSessionCookie)
		{
			return;
		}
		try
		{
			if (isSignupSession)
			{
				DateTime sessionStartTime = userFactory.GetUser(userId)?.Created ?? DateTime.Now;
				WebSessionEventPublisher.Publish(userId, platformTypeId, sessionStartTime, isSignupSession: true);
				return;
			}
			if (actionDescriptor != null)
			{
				object[] outputCacheAttribute = actionDescriptor.GetCustomAttributes(typeof(OutputCacheAttribute), true);
				if (outputCacheAttribute != null && outputCacheAttribute.Length != 0)
				{
					return;
				}
			}
			GetOrCreateSessionCookie(out var created);
			if (created)
			{
				WebSessionEventPublisher.Publish(userId, platformTypeId, DateTime.Now, isSignupSession: false);
			}
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
		}
	}

	public static void DeleteSessionCookie(HttpContext context)
	{
		if (!context.Request.Browser.Cookies)
		{
			return;
		}
		RobloxCookie cookie = RobloxCookie.Get(context, SessionCookie.CookieName);
		if (cookie != null)
		{
			if (Roblox.Web.Code.Properties.Settings.Default.SessionCookieDomainSetDomainOnDeleteEnabled)
			{
				cookie.Domain = RobloxEnvironment.Domain;
			}
			cookie.Delete();
		}
	}

	public static RobloxCookie GetSessionCookie()
	{
		HttpContext context = HttpContext.Current;
		if (!context.Request.Browser.Cookies)
		{
			return null;
		}
		return RobloxCookie.Get(context, SessionCookie.CookieName);
	}

	private static RobloxCookie GetOrCreateSessionCookie(out bool created)
	{
		HttpContext context = HttpContext.Current;
		created = false;
		if (!context.Request.Browser.Cookies)
		{
			return null;
		}
		RobloxCookie cookie = GetSessionCookie();
		if (cookie == null)
		{
			cookie = RobloxCookie.GetOrCreate(context, SessionCookie.CookieName, SessionCookie.ExpirationLength);
			_UpdateCookie(cookie, Guid.NewGuid());
			created = true;
		}
		else
		{
			if (Roblox.Web.Properties.Settings.Default.SessionCookieSetsDomain)
			{
				cookie.SetDomain(RobloxEnvironment.Domain);
			}
			cookie.Save(SessionCookie.ExpirationLength);
		}
		return cookie;
	}

	private static void _UpdateCookie(RobloxCookie cookie, Guid sessionId)
	{
		cookie.SetValue(SessionCookie.SessionIdKey, sessionId.ToString());
		if (Roblox.Web.Properties.Settings.Default.SessionCookieSetsDomain)
		{
			cookie.SetDomain(RobloxEnvironment.Domain);
		}
		cookie.Save(SessionCookie.ExpirationLength);
	}
}
