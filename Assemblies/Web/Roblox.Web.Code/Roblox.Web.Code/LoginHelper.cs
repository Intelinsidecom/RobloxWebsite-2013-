using System;
using System.Web;
using Roblox.Platform.IpAddresses;
using Roblox.Platform.Membership;
using Roblox.Platform.Presence;

namespace Roblox.Web.Code;

public class LoginHelper
{
	/// <summary>
	/// Represents a reason that logging in can fail.
	/// </summary>
	public enum LoginFailureReason
	{
		/// <summary>
		/// Logging in did not fail.
		/// </summary>
		None,
		/// <summary>
		/// The captcha was required but no captcha information was given.
		/// </summary>
		CaptchaMissing,
		/// <summary>
		/// The captcha was required but the captcha information given was invalid.
		/// </summary>
		CaptchaIncorrect,
		/// <summary>
		/// The user's credentials were invalid.
		/// </summary>
		Credentials
	}

	[Obsolete("Use platform name instead of platform type id")]
	public static void UpdateLoginInformation(IUser user, string userHostAddress, IPresenceRegistrar presenceRegistrar, byte platformTypeId, IAccountIpAddressRecorder accountIpAddressRecorder)
	{
		long? guestId = UserHelper.GetOrCreateCurrentGuestId();
		if (guestId.HasValue)
		{
			GuestFactory.Build(guestId.Value).RegisterAbsenceFromWebsite(presenceRegistrar);
		}
		user.PingFromLogin(presenceRegistrar, GetLocation(), platformTypeId);
		accountIpAddressRecorder.RecordHostAddressInBackground(user.AccountId, userHostAddress);
	}

	public static void UpdateLoginInformation(IUser user, string userHostAddress, IPresenceRegistrar presenceRegistrar, string platformName, IAccountIpAddressRecorder accountIpAddressRecorder)
	{
		long? guestId = UserHelper.GetOrCreateCurrentGuestId();
		if (guestId.HasValue)
		{
			GuestFactory.Build(guestId.Value).RegisterAbsenceFromWebsite(presenceRegistrar);
		}
		presenceRegistrar.PingFromLogin(user, GetLocation(), platformName);
		accountIpAddressRecorder.RecordHostAddressInBackground(user.AccountId, userHostAddress);
	}

	private static string GetLocation()
	{
		try
		{
			return HttpContext.Current.Request.Url.AbsolutePath;
		}
		catch
		{
			return "/";
		}
	}
}
