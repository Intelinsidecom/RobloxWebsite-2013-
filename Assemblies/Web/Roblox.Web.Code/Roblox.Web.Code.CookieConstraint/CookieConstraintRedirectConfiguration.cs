using System;

namespace Roblox.Web.Code.CookieConstraint;

/// <summary>
/// Describes the redirect action of a cookie constraint attribute or module.
/// </summary>
public class CookieConstraintRedirectConfiguration
{
	private readonly Func<bool> _IsConstraintEnabled;

	private readonly Func<string> _RelativeUrl;

	private readonly Func<string> _RedirectDomain;

	/// <summary>
	/// Returns whether this module should be enabled.
	/// </summary>
	public bool IsCookieConstraintEnabled => _IsConstraintEnabled();

	/// <summary>
	/// Returns the relative URL of the cookie constraint redirect page.
	/// </summary>
	public string CookieConstraintRedirectRelativeUrl => _RelativeUrl();

	/// <summary>
	/// Returns the domain of the cookie constraint redirect page.
	/// </summary>
	public string CookieConstraintRedirectDomain => _RedirectDomain();

	/// <summary>
	/// The absolute URL of the cookie constraint page.
	/// </summary>
	public string CookieConstraintRedirectAbsoluteUrl => CookieConstraintRedirectDomain + CookieConstraintRedirectRelativeUrl;

	public CookieConstraintRedirectConfiguration(Func<bool> isCookieConstraintEnabled, Func<string> redirectRelativeUrl, Func<string> redirectDomain)
	{
		_IsConstraintEnabled = isCookieConstraintEnabled;
		_RedirectDomain = redirectDomain;
		_RelativeUrl = redirectRelativeUrl;
	}
}
