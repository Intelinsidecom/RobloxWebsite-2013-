using System.Collections.Generic;
using Roblox.DataV2.Core;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.TranslationStorage;
using Roblox.Platform.Universes;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <summary>
/// The class to get display name/description for universe(s).
/// </summary>
public interface IUniverseDisplayInformationAccessor
{
	/// <summary>
	/// Get the display name of an universe in a specific locale.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="supportedLocale">The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" />.</param>
	/// <returns>The display name.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="universe" /> is null.</exception>
	string GetDisplayName(IUniverse universe, ISupportedLocale supportedLocale);

	/// <summary>
	/// Get the display description of an universe in a specific locale.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="supportedLocale">The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" />.</param>
	/// <returns>The display description.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="universe" /> is null.</exception>
	string GetDisplayDescription(IUniverse universe, ISupportedLocale supportedLocale);

	/// <summary>
	/// Get the display names of universes in a specific locale.
	/// </summary>
	/// <param name="universes">The <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" /> of <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="supportedLocale">The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" />.</param>
	/// <returns>An <see cref="T:System.Collections.Generic.IDictionary`2" /> using <see cref="T:Roblox.Platform.Universes.IUniverse" /> as key and display name as value.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="universes" /> is null.</exception>
	IDictionary<IUniverse, string> GetDisplayNamesForUniverses(IReadOnlyCollection<IUniverse> universes, ISupportedLocale supportedLocale);

	/// <summary>
	/// Get the display descriptions of universes in a specific locale.
	/// </summary>
	/// <param name="universes">The <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" /> of <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="supportedLocale">The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" />.</param>
	/// <returns>An <see cref="T:System.Collections.Generic.IDictionary`2" /> using <see cref="T:Roblox.Platform.Universes.IUniverse" /> as key and display description as value.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="universes" /> is null.</exception>
	IDictionary<IUniverse, string> GetDisplayDescriptionsForUniverses(IReadOnlyCollection<IUniverse> universes, ISupportedLocale supportedLocale);

	/// <summary>
	/// Get all the available display names of an universe in different languages.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <returns>An <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" /> of <see cref="T:Roblox.Platform.UniverseDisplayInformation.IUniverseDisplayNameForLanguage" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="universe" /> is null.</exception>
	IReadOnlyCollection<IUniverseDisplayNameForLanguage> GetDisplayNamesForAllLanguages(IUniverse universe);

	/// <summary>
	/// Get all the available display descriptions of an universe in different languages.
	/// </summary>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <returns>An <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" /> of <see cref="T:Roblox.Platform.UniverseDisplayInformation.IUniverseDisplayDescriptionForLanguage" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="universe" /> is null.</exception>
	IReadOnlyCollection<IUniverseDisplayDescriptionForLanguage> GetDisplayDescriptionsForAllLanguages(IUniverse universe);

	/// <summary>
	/// Gets the display name history.
	/// </summary>
	/// <param name="universe">The universe.</param>
	/// <param name="language">The language.</param>
	/// <param name="sourceLanguage">The source language.</param>
	/// <param name="exclusiveStartId">The exclusive start identifier.</param>
	/// <param name="count">The count.</param>
	/// <param name="sortOrder">The sort order.</param>
	/// <returns>
	/// A <see cref="T:Roblox.Platform.TranslationStorage.IGetTranslationHistoryResult" />.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if universe is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="language" /> is not null and same as <paramref name="sourceLanguage" />.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if the exclusive start Id was invalid.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if there was any error in getting the history.</exception>
	IGetTranslationHistoryResult GetDisplayNameHistory(IUniverse universe, ILanguageFamily language, ILanguageFamily sourceLanguage, string exclusiveStartId, int count, SortOrder sortOrder);

	/// <summary>
	/// Gets the display description history.
	/// </summary>
	/// <param name="universe">The universe.</param>
	/// <param name="language">The language.</param>
	/// <param name="sourceLanguage">The source language.</param>
	/// <param name="exclusiveStartId">The exclusive start identifier.</param>
	/// <param name="count">The count.</param>
	/// <param name="sortOrder">The sort order.</param>
	/// <returns>
	/// A <see cref="T:Roblox.Platform.TranslationStorage.IGetTranslationHistoryResult" />.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if universe is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="language" /> is not null and same as <paramref name="sourceLanguage" />.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if the exclusive start Id was invalid.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if there was any error in getting the history.</exception>
	IGetTranslationHistoryResult GetDisplayDescriptionHistory(IUniverse universe, ILanguageFamily language, ILanguageFamily sourceLanguage, string exclusiveStartId, int count, SortOrder sortOrder);
}
