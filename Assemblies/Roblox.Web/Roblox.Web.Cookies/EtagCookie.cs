using System;
using System.Collections.Specialized;
using System.Web.Security;
using Roblox.Libraries.Cookies;

namespace Roblox.Web.Cookies;

public class EtagCookie : RobloxCookieBase
{
	private static readonly string _CookieName = "RBXImageCache";

	public static readonly RobloxCookieIdentifier CookieIdentifier = new RobloxCookieIdentifier(_CookieName);

	/// <summary>
	/// Etag data (usually an encrypted string)
	/// </summary>
	public string Etag { get; set; }

	protected override string Name => _CookieName;

	public override bool HttpOnly => true;

	protected override TimeSpan? _ExpirationLength => null;

	public override string Domain
	{
		get
		{
			if (!string.IsNullOrEmpty(base.Domain))
			{
				return base.Domain;
			}
			return FormsAuthentication.CookieDomain;
		}
		set
		{
			base.Domain = value;
		}
	}

	public override NameValueCollection DoSerializeValues()
	{
		return new NameValueCollection { ["timg"] = Etag };
	}

	public override void DoDeSerializeValues(NameValueCollection keyValues)
	{
		Etag = keyValues["timg"];
	}
}
