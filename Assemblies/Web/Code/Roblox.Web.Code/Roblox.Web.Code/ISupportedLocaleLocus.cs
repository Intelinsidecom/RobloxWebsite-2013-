using Roblox.Platform.Localization.Core;

namespace Roblox.Web.Code;

public interface ISupportedLocaleLocus
{
	/// <summary>
	/// Is locale enabled for full experience
	/// </summary>
	bool IsEnabledForFullExperience { get; set; }

	/// <summary>
	/// Is locale enabled for signup and login
	/// </summary>
	bool IsEnabledForSignupAndLogin { get; set; }

	/// <summary>
	/// Supported locale
	/// </summary>
	ISupportedLocale Locale { get; set; }
}
