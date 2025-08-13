using System.Collections.Generic;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Universes;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <summary>
/// A interface to get localized icons.
/// </summary>
public interface IUniverseDisplayIconAccessor
{
	/// <summary>
	/// Get localized icon for an universe if possible. Otherwise return root place icon.
	/// </summary>
	/// <param name="universe"></param>
	/// <param name="supportedLocale"></param>
	/// <param name="sourceLanguage"></param>
	/// <returns></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="universe" /> is null.</exception>
	long? GetDisplayIcon(IUniverse universe, ISupportedLocale supportedLocale, ILanguageFamily sourceLanguage);

	/// <summary>
	/// Get localized icons for universes if possible.  Otherwise return root place icons.
	/// </summary>
	/// <param name="universes"></param>
	/// <param name="supportedLocale"></param>
	/// <param name="sourceLanguageDictionary"></param>
	/// <returns></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="universes" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="sourceLanguageDictionary" /> is null.</exception>
	IDictionary<IUniverse, long?> GetDisplayIconsForUniverses(IReadOnlyCollection<IUniverse> universes, ISupportedLocale supportedLocale, IReadOnlyDictionary<IUniverse, ILanguageFamily> sourceLanguageDictionary);

	/// <summary>
	/// Get all available source and localized icons of a universe.
	/// </summary>
	/// <param name="universe"></param>
	/// <param name="sourceLanguage"></param>
	/// <returns></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="universe" /> is null.</exception>
	IReadOnlyCollection<UniverseDisplayIconForLanguage> GetDisplayIconsForAllLanguages(IUniverse universe, ILanguageFamily sourceLanguage);
}
