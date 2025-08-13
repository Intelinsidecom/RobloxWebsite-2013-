using System;
using System.Web;
using Roblox.EphemeralCounters;
using Roblox.Platform.Captcha;
using Roblox.Platform.Captcha.Implementations;
using Roblox.Platform.Counters;
using Roblox.Platform.Marketing;
using Roblox.Platform.Membership;
using Roblox.Web.Authentication;
using Roblox.Web.Code.Properties;
using Roblox.Web.Devices;

namespace Roblox.Web.Code.Captcha;

public class CaptchaUtility : ICaptchaUtility
{
	private readonly IClientDeviceIdentifier _ClientDeviceIdentifier;

	private readonly EphemeralCounterFactory _EphemeralCounterFactory;

	private readonly IWebAuthenticationReader _WebAuthenticationReader;

	private readonly Factories _CaptchaFactory;

	private readonly IDurableCounterFactory _DurableCounterFactory;

	private readonly IWebDeviceHandleInspector _WebDeviceHandleInspector;

	public CaptchaUtility(IClientDeviceIdentifier clientDeviceIdentifier, IWebDeviceHandleInspector webDeviceHandleInspector, EphemeralCounterFactory ephemeralCounterFactory, IWebAuthenticationReader webAuthenticationReader, Factories captchaFactory, IDurableCounterFactory durableCounterFactory)
	{
		_WebDeviceHandleInspector = webDeviceHandleInspector ?? throw new ArgumentNullException("webDeviceHandleInspector");
		_ClientDeviceIdentifier = clientDeviceIdentifier ?? throw new ArgumentNullException("clientDeviceIdentifier");
		_EphemeralCounterFactory = ephemeralCounterFactory ?? throw new ArgumentNullException("ephemeralCounterFactory");
		_WebAuthenticationReader = webAuthenticationReader ?? throw new ArgumentNullException("webAuthenticationReader");
		_CaptchaFactory = captchaFactory ?? throw new ArgumentNullException("captchaFactory");
		_DurableCounterFactory = durableCounterFactory ?? throw new ArgumentNullException("durableCounterFactory");
	}

	public bool IsInApp(IBrowserTracker browserTracker, HttpContext httpContext)
	{
		string userAgent = httpContext.Request.UserAgent;
		bool inApp = _ClientDeviceIdentifier.IsRobloxApp(userAgent);
		bool deviceHandleRequired = (Settings.Default.DeviceHandleForWin10Enabled && _ClientDeviceIdentifier.IsRobloxWindowsApp(userAgent)) || (Settings.Default.DeviceHandleForAndroidEnabled && _ClientDeviceIdentifier.IsRobloxAndroidApp(userAgent)) || (Settings.Default.DeviceHandleForIOSEnabled && _ClientDeviceIdentifier.IsRobloxIOSApp(userAgent));
		bool inspectDeviceHandle = Settings.Default.DeviceHandleWebCaptchaCheckEnabled && inApp;
		ulong browserTrackerId = (ulong)(browserTracker?.Id ?? 0);
		if (deviceHandleRequired || inspectDeviceHandle)
		{
			bool deviceHandleValid = _WebDeviceHandleInspector.IsValidDeviceHandleRequest(httpContext.Request, browserTrackerId);
			if (deviceHandleRequired)
			{
				inApp = deviceHandleValid;
			}
		}
		return inApp;
	}

	public bool IsCaptchaOnRequestEnabled(RequestType requestType)
	{
		IUser authenticatedUser = _WebAuthenticationReader.GetAuthenticatedUser();
		if (authenticatedUser == null)
		{
			return false;
		}
		return GetCaptchaVerifier(authenticatedUser, requestType).IsCaptchaEnabled;
	}

	public CaptchaVerifier GetCaptchaVerifier(IUser authenticatedUser, RequestType requestType)
	{
		ActionType actionType;
		switch (requestType)
		{
		case RequestType.PrivateMessage:
			actionType = ActionType.PrivateMessage;
			break;
		case RequestType.FriendRequest:
		case RequestType.FollowRequest:
		case RequestType.JoinGroup:
		case RequestType.PostComment:
		case RequestType.Favorite:
			actionType = ActionType.UserAction;
			break;
		default:
			actionType = ActionType.UserAction;
			break;
		}
		Roblox.Platform.Captcha.Action captchaAction = new ActionFactory(actionType, _CaptchaFactory).GetUserCaptchaAction(HttpUtility.UrlEncode(authenticatedUser.Name));
		return new CaptchaVerifier(requestType, authenticatedUser, captchaAction, _DurableCounterFactory, _EphemeralCounterFactory);
	}
}
