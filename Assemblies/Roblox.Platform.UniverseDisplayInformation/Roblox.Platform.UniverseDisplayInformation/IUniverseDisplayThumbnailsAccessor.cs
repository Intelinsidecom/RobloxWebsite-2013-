using System.Collections.Generic;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Universes;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <summary>
/// An interface to get localized game asset media.
/// </summary>
public interface IUniverseDisplayThumbnailsAccessor
{
	/// <summary>
	/// Gets the display asset media.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="supportedLocale">The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" />.</param>
	/// <param name="sourceLanguageFamily">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" /> of the sourceLanguage.</param>
	/// <returns>
	/// A <see cref="T:System.Collections.Generic.IReadOnlyList`1" /> of thumbnail asset Ids..
	/// </returns>
	IReadOnlyList<long> GetDisplayMediaAssets(IUniverse universe, ISupportedLocale supportedLocale, ILanguageFamily sourceLanguageFamily);

	/// <summary>
	/// Gets the display asset media for all languages.
	/// </summary>
	/// <param name="universe">The universe.</param>
	/// <param name="sourceLanguageFamily">The source language.</param>
	/// <returns>
	/// A <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" /> of <see cref="T:Roblox.Platform.UniverseDisplayInformation.UniverseDisplayMediaAssetsForLanguage" />
	/// </returns>
	IReadOnlyCollection<UniverseDisplayMediaAssetsForLanguage> GetDisplayMediaAssetsForAllLanguages(IUniverse universe, ILanguageFamily sourceLanguageFamily);
}
