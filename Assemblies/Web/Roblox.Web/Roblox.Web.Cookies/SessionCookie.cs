using System;
using System.Collections.Specialized;
using Roblox.Configuration;
using Roblox.Libraries.Cookies;
using Roblox.Web.Properties;

namespace Roblox.Web.Cookies;

public class SessionCookie : RobloxCookieBase
{
	private static readonly string _Name = "RBXSessionTracker";

	public static readonly RobloxCookieIdentifier CookieIdentifier = new RobloxCookieIdentifier(_Name);

	public static readonly string CookieName = "RBXSessionTracker";

	public static readonly string SessionIdKey = "sessionid";

	protected override string Name => _Name;

	protected override TimeSpan? _ExpirationLength => Settings.Default.SessionCookieExpiration;

	public override string Domain
	{
		get
		{
			if (Settings.Default.SessionCookieSetsDomain)
			{
				return RobloxEnvironment.Domain;
			}
			return base.Domain;
		}
	}

	public static TimeSpan ExpirationLength => Settings.Default.SessionCookieExpiration;

	public Guid? SessionId { get; set; }

	public override NameValueCollection DoSerializeValues()
	{
		NameValueCollection values = new NameValueCollection();
		if (SessionId.HasValue)
		{
			values.Add(SessionIdKey, SessionId.Value.ToString());
		}
		return values;
	}

	public override void DoDeSerializeValues(NameValueCollection keyValues)
	{
		if (Guid.TryParse(keyValues[SessionIdKey], out var sessionId))
		{
			SessionId = sessionId;
		}
		else
		{
			SessionId = null;
		}
	}
}
