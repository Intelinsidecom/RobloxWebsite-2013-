using Roblox.Platform.Localization.Core;

namespace Roblox.Web.Code;

internal class SupportedLocaleLocus : ISupportedLocaleLocus
{
	/// <summary>
	/// Is locale enabled for full experience
	/// </summary>
	public bool IsEnabledForFullExperience { get; set; }

	/// <summary>
	/// Is locale enabled for signup and login
	/// </summary>
	public bool IsEnabledForSignupAndLogin { get; set; }

	/// <summary>
	/// Supported locale
	/// </summary>
	public ISupportedLocale Locale { get; set; }
}
