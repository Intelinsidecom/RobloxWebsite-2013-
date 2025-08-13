using System;
using Roblox.Platform.AccountPins;
using Roblox.Platform.Membership;
using Roblox.Web.Authentication.Properties;

namespace Roblox.Web.Authentication;

/// <summary>
/// A web implementation of <see cref="T:Roblox.Web.Authentication.IAccountPinAuthenticator" />.
/// </summary>
/// <seealso cref="T:Roblox.Web.Authentication.IAccountPinAuthenticator" />
public class AccountPinAuthenticator : IAccountPinAuthenticator
{
	private AccountPinsDomainFactories DomainFactories { get; }

	internal virtual string _HashSalt => Settings.Default.AccountPinAuthHashSalt;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.Authentication.AccountPinAuthenticator" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown if the domainFactories is null.</exception>
	public AccountPinAuthenticator(AccountPinsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new ArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public bool IsLocked(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (!DomainFactories.AccountPinConfigurationProvider.IsAccountPinFeatureEnabledForUser(user))
		{
			return false;
		}
		RobloxAuthenticationCookie cookie = GetAuthenticationCookie();
		if (cookie == null)
		{
			return false;
		}
		return DomainFactories.AccountPinLockProvider.IsLocked(user, GetHashedCookieString(cookie));
	}

	public IPinEntry GetPinEntry(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (!DomainFactories.AccountPinConfigurationProvider.IsAccountPinFeatureEnabledForUser(user))
		{
			return null;
		}
		RobloxAuthenticationCookie cookie = GetAuthenticationCookie();
		if (cookie == null)
		{
			return null;
		}
		return DomainFactories.PinEntryFactory.Get(user, GetHashedCookieString(cookie));
	}

	public IPinEntry Unlock(IUser user, string pin)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (!DomainFactories.AccountPinConfigurationProvider.IsAccountPinFeatureEnabledForUser(user))
		{
			return null;
		}
		if (string.IsNullOrWhiteSpace(pin))
		{
			throw new ArgumentException("pin");
		}
		RobloxAuthenticationCookie cookie = GetAuthenticationCookie();
		if (cookie == null)
		{
			return null;
		}
		return DomainFactories.PinValidator.Unlock(user, pin, GetHashedCookieString(cookie));
	}

	internal virtual RobloxAuthenticationCookie GetAuthenticationCookie()
	{
		return RobloxAuthenticationCookie.GetCurrent();
	}

	internal virtual string GetHashedCookieString(RobloxAuthenticationCookie cookie)
	{
		string cookieValueString = cookie.SessionToken.Value;
		return HashGenerator.HashString(_HashSalt, cookieValueString);
	}
}
