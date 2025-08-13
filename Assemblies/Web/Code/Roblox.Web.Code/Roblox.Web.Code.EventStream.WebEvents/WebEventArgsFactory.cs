using System;
using System.Web;
using Roblox.Common;
using Roblox.Marketing;
using Roblox.Platform.Devices;
using Roblox.Platform.EventStream.WebEvents;
using Roblox.Platform.Marketing;
using Roblox.Platform.Membership;
using Roblox.Web.Authentication;
using Roblox.Web.Code.Marketing;
using Roblox.Web.Cookies;
using Roblox.Web.Devices;

namespace Roblox.Web.Code.EventStream.WebEvents;

public class WebEventArgsFactory : IWebEventArgsFactory
{
	private readonly IWebAuthenticator _WebAuthenticator;

	private readonly EventTarget _DefaultEventTarget;

	private readonly IClientDeviceIdentifier _ClientDeviceIdentifier;

	/// <summary>
	/// Creates a new instance of <see cref="T:Roblox.Web.Code.EventStream.WebEvents.IWebEventArgsFactory" />.
	/// </summary>
	/// <param name="webAuthenticator">The <see cref="T:Roblox.Web.Authentication.IWebAuthenticator" />.</param>
	/// <param name="defaultEventTarget">The <see cref="T:Roblox.Platform.EventStream.WebEvents.EventTarget" />.</param>
	/// <param name="clientDeviceIdentifier">The <see cref="T:Roblox.Web.Devices.IClientDeviceIdentifier" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="webAuthenticator" /> or <paramref name="clientDeviceIdentifier" /> is null.</exception>
	public WebEventArgsFactory(IWebAuthenticator webAuthenticator, EventTarget defaultEventTarget, IClientDeviceIdentifier clientDeviceIdentifier)
	{
		if (webAuthenticator == null)
		{
			throw new ArgumentNullException("webAuthenticator");
		}
		if (clientDeviceIdentifier == null)
		{
			throw new ArgumentNullException("clientDeviceIdentifier");
		}
		_WebAuthenticator = webAuthenticator;
		_DefaultEventTarget = defaultEventTarget;
		_ClientDeviceIdentifier = clientDeviceIdentifier;
	}

	/// <summary>
	/// Creates a WebEventArgs object and also creates a GuestId cookie and Browser Tracker cookie if they do not exist.
	/// </summary>
	/// <remarks>Do not call this method to create WebEventArgs if WebEventArgs are being created after a Response.Redirect call with endResponse parameter value set to False or 
	/// if WebEventArgs are being created in an HttpModule's OnEndRequest method.</remarks>
	/// <typeparam name="TWebEventArgs">Type of WebEventArgs to be created</typeparam>
	/// <param name="httpContext">Current HttpContext</param>
	/// <returns></returns>
	/// <inheritdoc cref="T:Roblox.Web.Code.EventStream.WebEvents.IWebEventArgsFactory" />
	public TWebEventArgs Create<TWebEventArgs>(HttpContext httpContext) where TWebEventArgs : WebEventArgs, new()
	{
		if (httpContext == null)
		{
			throw new ArgumentNullException("httpContext");
		}
		TWebEventArgs webEventArgs = GetBasicArgsWithoutBrowserTrackerId<TWebEventArgs>(httpContext);
		IBrowserTracker browserTracker = PlatformMarketingHelper.GetBrowserTracker(httpContext);
		if (browserTracker != null)
		{
			webEventArgs.BrowserTrackerId = browserTracker.Id;
		}
		webEventArgs.ClientIp = httpContext.GetOriginIP();
		return webEventArgs;
	}

	/// <summary>
	/// Creates a new <see cref="T:Roblox.Platform.EventStream.WebEvents.WebEventArgs" /> without updating GuestId and BrowserTracker cookie.
	/// </summary>
	/// <typeparam name="TWebEventArgs">The type of the web event arguments.</typeparam>
	/// <param name="httpContext">The HTTP context.</param>
	/// <returns>The created <see cref="T:Roblox.Platform.EventStream.WebEvents.WebEventArgs" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="httpContext" /> is null.</exception>
	public TWebEventArgs CreateWithoutUpdatingGuestIdCookieAndBtCookie<TWebEventArgs>(HttpContext httpContext) where TWebEventArgs : WebEventArgs, new()
	{
		if (httpContext == null)
		{
			throw new ArgumentNullException("httpContext");
		}
		TWebEventArgs webEventArgs = new TWebEventArgs
		{
			ClientIp = httpContext.GetOriginIP(),
			UserAgent = httpContext.Request.UserAgent,
			GuestId = UserHelper.GetOrCreateCurrentGuestIdWithoutSettingCookie(),
			Target = _DefaultEventTarget
		};
		webEventArgs = GetBasicArgsWithoutBrowserTrackerId(httpContext, webEventArgs);
		long? browserTrackerId = MarketingHelper.GetBrowserTrackerIDWithoutCreatingOrUpdatingCookie(httpContext);
		if (browserTrackerId.HasValue)
		{
			webEventArgs.BrowserTrackerId = browserTrackerId.Value;
		}
		return webEventArgs;
	}

	private TWebEventArgs GetBasicArgsWithoutBrowserTrackerId<TWebEventArgs>(HttpContext httpContext) where TWebEventArgs : WebEventArgs, new()
	{
		TWebEventArgs webEventArgs = new TWebEventArgs
		{
			ClientIp = httpContext.GetOriginIP(),
			UserAgent = httpContext.Request.UserAgent,
			GuestId = UserHelper.GetOrCreateCurrentGuestId(),
			Target = _DefaultEventTarget
		};
		return GetBasicArgsWithoutBrowserTrackerId(httpContext, webEventArgs);
	}

	private TWebEventArgs GetBasicArgsWithoutBrowserTrackerId<TWebEventArgs>(HttpContext httpContext, TWebEventArgs webEventArgs) where TWebEventArgs : WebEventArgs, new()
	{
		IPlatform platformType = _ClientDeviceIdentifier.GetPlatformByUserAgent(httpContext.Request.UserAgent);
		if (platformType != null)
		{
			webEventArgs.PlatformTypeId = platformType.PlatformTypeId;
		}
		if (httpContext.Request.UrlReferrer != null)
		{
			webEventArgs.ReferrerUrl = httpContext.Request.UrlReferrer.ToString();
		}
		IUser authenticatedUser = _WebAuthenticator.GetAuthenticatedUser();
		if (authenticatedUser != null)
		{
			webEventArgs.UserId = authenticatedUser.Id;
			RobloxCookie sessionCookie = SessionCookieHelper.GetSessionCookie();
			if (sessionCookie != null)
			{
				webEventArgs.SessionId = sessionCookie.GetValue(SessionCookie.SessionIdKey);
			}
		}
		return webEventArgs;
	}
}
