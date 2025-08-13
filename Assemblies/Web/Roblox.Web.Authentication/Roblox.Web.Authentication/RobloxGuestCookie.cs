using System;
using System.Collections.Specialized;
using System.Web.Security;
using Roblox.Libraries.Cookies;

namespace Roblox.Web.Authentication;

public class RobloxGuestCookie : RobloxCookieBase
{
	private const string GuestIdKey = "UserID";

	private const string GuestGenderKey = "Gender";

	private const string GuestCookieName = "GuestData";

	public static readonly RobloxCookieIdentifier GuestCookieIdentifier = new RobloxCookieIdentifier("GuestData");

	protected override string Name => "GuestData";

	protected override TimeSpan? _ExpirationLength => TimeSpan.FromDays(10000.0);

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

	public string GuestId { get; set; }

	public string GuestGender { get; set; }

	public override NameValueCollection DoSerializeValues()
	{
		NameValueCollection result = new NameValueCollection();
		result["UserID"] = GuestId;
		if (!string.IsNullOrEmpty(GuestGender))
		{
			result["Gender"] = GuestGender;
		}
		return result;
	}

	public override void DoDeSerializeValues(NameValueCollection keyValues)
	{
		GuestId = keyValues["UserID"];
		GuestGender = keyValues["Gender"];
	}

	public static RobloxGuestCookie GetOrCreate()
	{
		return RobloxCookieHelper.GetOrCreate<RobloxGuestCookie>(GuestCookieIdentifier);
	}

	public static RobloxGuestCookie GetOrCreate(string guestId)
	{
		RobloxGuestCookie guestCookie = RobloxCookieHelper.Get<RobloxGuestCookie>(GuestCookieIdentifier);
		if (guestCookie == null || guestCookie.GuestId != guestId)
		{
			guestCookie?.Delete();
			guestCookie = RobloxCookieHelper.GetOrCreate<RobloxGuestCookie>(GuestCookieIdentifier);
			guestCookie.GuestId = guestId;
			guestCookie.Save();
		}
		return guestCookie;
	}
}
