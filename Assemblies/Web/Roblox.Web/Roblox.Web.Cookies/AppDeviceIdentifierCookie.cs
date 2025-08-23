using System;
using System.Collections.Specialized;
using Roblox.Configuration;
using Roblox.Libraries.Cookies;
using Roblox.Web.Properties;

namespace Roblox.Web.Cookies;

public class AppDeviceIdentifierCookie : RobloxCookieBase
{
	private static readonly string _CookieName = Settings.Default.AppDeviceIdentifierCookie_Name;

	public static readonly RobloxCookieIdentifier CookieIdentifier = new RobloxCookieIdentifier(_CookieName);

	/// <summary>
	/// Unique string that identifies a device.
	/// </summary>
	public string AppDeviceIdentifier { get; set; }

	protected override string Name => _CookieName;

	public override bool HttpOnly => false;

	protected override TimeSpan? _ExpirationLength => null;

	public override string Domain
	{
		get
		{
			return RobloxEnvironment.Domain;
		}
		set
		{
		}
	}

	public override NameValueCollection DoSerializeValues()
	{
		return new NameValueCollection { ["AppDeviceIdentifier"] = AppDeviceIdentifier };
	}

	public override void DoDeSerializeValues(NameValueCollection keyValues)
	{
		AppDeviceIdentifier = keyValues["AppDeviceIdentifier"];
	}
}
