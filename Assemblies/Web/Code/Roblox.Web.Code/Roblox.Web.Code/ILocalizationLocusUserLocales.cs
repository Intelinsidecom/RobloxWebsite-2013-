namespace Roblox.Web.Code;

/// <summary>
/// An interface to hold each localization locus locale.
/// </summary>
public interface ILocalizationLocusUserLocales
{
	/// <summary>
	/// The general experience supported locale.
	/// </summary>
	IUserLocale GeneralExperienceLocale { get; }

	/// <summary>
	/// The signup and login page supported locale.
	/// </summary>
	IUserLocale SignupAndLoginLocale { get; }

	/// <summary>
	/// The user generated content supported locale.
	/// </summary>
	IUserLocale UgcLocale { get; }
}
