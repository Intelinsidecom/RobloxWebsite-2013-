using System.Collections.Generic;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Moderation;

/// <summary>
/// Interface represents a factory object that is responsible for creating and 
/// retrieving <see cref="T:Roblox.Platform.Moderation.IModerationLocale" />.
/// </summary>
public interface IModerationLocaleFactory
{
	/// <summary>
	/// Get all <see cref="T:Roblox.Platform.Moderation.IModerationLocale" />s of the specified Active status.
	/// </summary>
	/// <param name="isActive">True if you want all active moderation locales, false if you want all deactived moderation locales</param>
	/// <returns>A collection of <see cref="T:Roblox.Platform.Moderation.IModerationLocale" />s.</returns>
	ICollection<IModerationLocale> GetAllModerationLocalesByActiveStatus(bool isActive);

	/// <summary>
	/// If we have an active <see cref="T:Roblox.Platform.Moderation.IModerationLocale" /> that maps to the input <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocaleIdentifier" />, return it. Otherwise, return null.
	/// </summary>
	/// <param name="localeIdentifier">The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocaleIdentifier" /> we want the moderation equivalent of</param>
	/// <returns>May return null if equivalent active <see cref="T:Roblox.Platform.Moderation.IModerationLocale" /> cannot be found</returns>
	IModerationLocale GetActiveByLocalizationLocale(ISupportedLocaleIdentifier localeIdentifier);

	/// <summary>
	/// Looks up the <see cref="T:Roblox.Platform.Moderation.IModerationLocale" /> for the given locale, and if it does not find it, creates it with IsActive set to false.
	/// </summary>
	/// <param name="locale">The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" /> we want the moderation equivalent of</param>
	IModerationLocale GetOrCreate(ISupportedLocale locale);
}
