using System;
using System.Diagnostics.CodeAnalysis;
using System.Web;
using Roblox.Platform.Membership;
using Roblox.Platform.StaticContent;
using Roblox.Web.Authentication;
using Roblox.Web.StaticContent.Properties;

namespace Roblox.Web.StaticContent;

/// <inheritdoc cref="T:Roblox.Platform.StaticContent.IComponentSuffixProvider" />
public class CookieBasedComponentSuffixProvider : IComponentSuffixProvider
{
	private const string _ComponentSuffixCookieName = "WebAppComponentSuffix";

	private readonly IComponentSuffixProvider _FallbackComponentSuffixProvider;

	private readonly IContentValidationApprover _ContentValidationApprover;

	private readonly IWebAuthenticationReader _WebAuthenticationReader;

	private readonly IStaticContentSettings _StaticContentSettings;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.StaticContent.CookieBasedComponentSuffixProvider" />.
	/// </summary>
	/// <param name="contentValidationApprover">An <see cref="T:Roblox.Platform.StaticContent.IContentValidationApprover" />.</param>
	/// <param name="webAuthenticationReader">An <see cref="T:Roblox.Web.Authentication.IWebAuthenticationReader" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="contentValidationApprover" />
	/// - <paramref name="webAuthenticationReader" />
	/// </exception>
	[ExcludeFromCodeCoverage]
	public CookieBasedComponentSuffixProvider(IContentValidationApprover contentValidationApprover, IWebAuthenticationReader webAuthenticationReader)
		: this(new SettingsBasedComponentSuffixProvider(), contentValidationApprover, webAuthenticationReader, Settings.Default)
	{
	}

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.StaticContent.CookieBasedComponentSuffixProvider" />.
	/// </summary>
	/// <param name="fallbackComponentSuffixProvider">An <see cref="T:Roblox.Platform.StaticContent.IComponentSuffixProvider" /> to fall back on if the cookie is unavailable.</param>
	/// <param name="contentValidationApprover">An <see cref="T:Roblox.Platform.StaticContent.IContentValidationApprover" />.</param>
	/// <param name="webAuthenticationReader">An <see cref="T:Roblox.Web.Authentication.IWebAuthenticationReader" />.</param>
	/// <param name="staticContentSettings">An <see cref="T:Roblox.Web.StaticContent.Properties.IStaticContentSettings" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="fallbackComponentSuffixProvider" />
	/// - <paramref name="contentValidationApprover" />
	/// - <paramref name="webAuthenticationReader" />
	/// - <paramref name="staticContentSettings" />
	/// </exception>
	public CookieBasedComponentSuffixProvider(IComponentSuffixProvider fallbackComponentSuffixProvider, IContentValidationApprover contentValidationApprover, IWebAuthenticationReader webAuthenticationReader, IStaticContentSettings staticContentSettings)
	{
		_FallbackComponentSuffixProvider = fallbackComponentSuffixProvider ?? throw new ArgumentNullException("fallbackComponentSuffixProvider");
		_ContentValidationApprover = contentValidationApprover ?? throw new ArgumentNullException("contentValidationApprover");
		_WebAuthenticationReader = webAuthenticationReader ?? throw new ArgumentNullException("webAuthenticationReader");
		_StaticContentSettings = staticContentSettings ?? throw new ArgumentNullException("staticContentSettings");
	}

	/// <inheritdoc cref="M:Roblox.Platform.StaticContent.IComponentSuffixProvider.GetComponentSuffix" />
	public string GetComponentSuffix()
	{
		if (_StaticContentSettings.IsCookieBasedComponentSuffixEnabled)
		{
			IUser authenticatedUser = _WebAuthenticationReader.GetAuthenticatedUser();
			if (_ContentValidationApprover.CanAccessInvalidatedContent(authenticatedUser))
			{
				string cookieComponentSuffix = GetCookieComponentSuffix();
				if (!string.IsNullOrWhiteSpace(cookieComponentSuffix))
				{
					return cookieComponentSuffix;
				}
			}
		}
		return _FallbackComponentSuffixProvider.GetComponentSuffix();
	}

	[ExcludeFromCodeCoverage]
	internal virtual string GetCookieComponentSuffix()
	{
		return RobloxCookie.Get(HttpContext.Current, "WebAppComponentSuffix")?.Value;
	}
}
