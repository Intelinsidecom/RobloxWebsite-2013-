using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Web;
using Roblox.Common;
using Roblox.Configuration;
using Roblox.Networking;
using Roblox.Web.Code.Properties;
using Roblox.Web.Properties;

namespace Roblox.Web.Code.CookieConstraint;

public class CookieConstraintVerifier : ICookieConstraintVerifier
{
	internal const string GameServerBypassHeaderName = "X-EnforceGameServerBypass";

	internal const string ForceConstraintHeaderName = "X-ForceMaintenanceMode";

	private readonly ICookieConstraintSettings _CookieConstraintSettings;

	private readonly ISettings _WebSettings;

	private readonly IGameServerRequestValidator _GameServerRequestValidator;

	internal IReadOnlyCollection<IpAddressRange> IpAddressBypassRanges = (IReadOnlyCollection<IpAddressRange>)(object)new IpAddressRange[0];

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Code.CookieConstraint.CookieConstraintVerifier" />.
	/// </summary>
	/// <remarks>
	/// If <paramref name="gameServerRequestValidator" /> is <c>null</c> game servers will not be able
	/// to bypass the cookie constraint.
	/// </remarks>
	/// <param name="gameServerRequestValidator">An <see cref="T:Roblox.Web.IGameServerRequestValidator" />.</param>
	public CookieConstraintVerifier(IGameServerRequestValidator gameServerRequestValidator)
		: this(Roblox.Web.Code.Properties.Settings.Default, Roblox.Web.Properties.Settings.Default, gameServerRequestValidator)
	{
		Roblox.Web.Code.Properties.Settings.Default.ReadValueAndMonitorChanges((Roblox.Web.Code.Properties.Settings s) => s.CookieConstraintIpBypassRangeCsv, delegate(string value)
		{
			IpAddressBypassRanges = IpAddressRange.ParseStringList(value);
		});
	}

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Code.CookieConstraint.CookieConstraintVerifier" />.
	/// </summary>
	/// <remarks>
	/// If <paramref name="gameServerRequestValidator" /> is <c>null</c> game servers will not be able
	/// to bypass the cookie constraint.
	/// </remarks>
	/// <param name="cookieConstraintSettings">An <see cref="T:Roblox.Web.Code.Properties.ICookieConstraintSettings" />.</param>
	/// <param name="webSettings">A <see cref="T:Roblox.Web.Properties.ISettings" />.</param>
	/// <param name="gameServerRequestValidator">An <see cref="T:Roblox.Web.IGameServerRequestValidator" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="cookieConstraintSettings" />
	/// - <paramref name="webSettings" />
	/// </exception>
	internal CookieConstraintVerifier(ICookieConstraintSettings cookieConstraintSettings, ISettings webSettings, IGameServerRequestValidator gameServerRequestValidator)
	{
		_CookieConstraintSettings = cookieConstraintSettings ?? throw new ArgumentNullException("cookieConstraintSettings");
		_WebSettings = webSettings ?? throw new ArgumentNullException("webSettings");
		_GameServerRequestValidator = gameServerRequestValidator;
	}

	public bool IsVerified(HttpContextBase httpContextBase)
	{
		if (!_CookieConstraintSettings.IsCookieConstraintEnabled)
		{
			return true;
		}
		if (httpContextBase?.Request == null || IsConstraintForced(httpContextBase.Request.Headers))
		{
			return false;
		}
		if (!httpContextBase.Request.IsLocal && !HasCookie(httpContextBase.Request) && !IsOptionsRequest(httpContextBase.Request) && !VerifyIpBypass(httpContextBase))
		{
			if (_CookieConstraintSettings.IsGameServerCookieConstraintBypassEnabled)
			{
				return IsRequestFromGameServer(httpContextBase);
			}
			return false;
		}
		return true;
	}

	internal bool IsRequestFromGameServer(HttpContextBase context)
	{
		if (_GameServerRequestValidator == null)
		{
			return false;
		}
		string[] gameServerBypassValues = (_WebSettings.IsGameServerOnlyHeaderBypassEnabled ? context.Request.Headers.GetValues("X-EnforceGameServerBypass") : null);
		if (gameServerBypassValues != null && gameServerBypassValues.Contains(_WebSettings.GameServerHeaderBypassValue))
		{
			return true;
		}
		return _GameServerRequestValidator.VerifyIpAccess(context.GetOriginIP());
	}

	internal bool HasCookie(HttpRequestBase request)
	{
		return request.Cookies.AllKeys.Contains(_CookieConstraintSettings.CookieConstraintCookieName);
	}

	internal bool VerifyIpBypass(HttpContextBase context)
	{
		System.Net.IPAddress ipAddress = System.Net.IPAddress.Parse(context.GetOriginIP());
		return IpAddressBypassRanges.Aggregate(seed: false, (bool result, IpAddressRange ipRange) => result || ipRange.IsInRange(ipAddress));
	}

	internal bool IsOptionsRequest(HttpRequestBase request)
	{
		return request.HttpMethod.Equals("OPTIONS", StringComparison.OrdinalIgnoreCase);
	}

	internal bool IsConstraintForced(NameValueCollection headers)
	{
		return headers?.AllKeys.Contains("X-ForceMaintenanceMode") ?? false;
	}
}
