using System.Collections.Generic;
using Roblox.DataV2.Core;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.TranslationStorage;

/// <summary>
/// An interface to access the translation storage service through client.
/// </summary>
public interface ITranslationStorageAccessor
{
	/// <summary>
	/// Retrieves the translation for the provided arguments.
	/// </summary>
	/// <param name="supportedLocale">The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" />.</param>
	/// <param name="contentSourceType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentSourceType" />.</param>
	/// <param name="contentVariantType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentVariantType" />.</param>
	/// <param name="contentSourceTargetId">The content source target identifier.</param>
	/// <returns>
	/// The translation for the passed in arguments.
	/// </returns>
	string GetTranslation(ISupportedLocale supportedLocale, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId);

	/// <summary>
	/// Retrieves the translation.
	/// </summary>
	/// <param name="languageFamily">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" />.</param>
	/// <param name="contentSourceType">TheType of the content source.</param>
	/// <param name="contentVariantType">Type of the content variant.</param>
	/// <param name="contentSourceTargetId">The content source target identifier.</param>
	/// <returns>
	/// The translation for the passed in arguments.
	/// </returns>
	string GetTranslation(ILanguageFamily languageFamily, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId);

	/// <summary>
	/// Gets the translations for the provided <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" /> of <paramref name="contentSourceTargetIds" />.
	/// </summary>
	/// <param name="supportedLocale">The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" />.</param>
	/// <param name="contentSourceType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentSourceType" />.</param>
	/// <param name="contentVariantType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentVariantType" />.</param>
	/// <param name="contentSourceTargetIds">The collection of content source target identifiers.</param>
	/// <returns>
	/// An <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" /> of <see cref="T:Roblox.Platform.TranslationStorage.ITranslationForContentSourceTargetId" /> corresponding to the passed in information.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="supportedLocale" /> is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="contentVariantType" /> is not supported or <paramref name="contentSourceTargetIds" /> is null or contains nulls.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown in case there is any exception while attempting to get the translations from the storage service.</exception>
	IReadOnlyCollection<ITranslationForContentSourceTargetId> GetTranslationsForContentSourceTargetIds(ISupportedLocale supportedLocale, ContentSourceType contentSourceType, ContentVariantType contentVariantType, IReadOnlyCollection<string> contentSourceTargetIds);

	/// <summary>
	/// Gets the translations for the provided <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" /> of <paramref name="contentSourceTargetIds" />.
	/// </summary>
	/// <param name="languageFamily">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" />.</param>
	/// <param name="contentSourceType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentSourceType" />.</param>
	/// <param name="contentVariantType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentVariantType" />.</param>
	/// <param name="contentSourceTargetIds">The collection of content source target identifiers.</param>
	/// <returns>
	/// An <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" /> of <see cref="T:Roblox.Platform.TranslationStorage.ITranslationForContentSourceTargetId" /> corresponding to the passed in information.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="languageFamily" /> is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="contentVariantType" /> is not supported or <paramref name="contentSourceTargetIds" /> is null or contains nulls.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown in case there is any exception while attempting to get the translations from the storage service.</exception>
	IReadOnlyCollection<ITranslationForContentSourceTargetId> GetTranslationsForContentSourceTargetIds(ILanguageFamily languageFamily, ContentSourceType contentSourceType, ContentVariantType contentVariantType, IReadOnlyCollection<string> contentSourceTargetIds);

	/// <summary>
	/// Gets the translation for content locales.
	/// </summary>
	/// <param name="contentSourceType">Type of the content source.</param>
	/// <param name="contentVariantType">Type of the content variant.</param>
	/// <param name="contentSourceTargetId">The content source target identifier.</param>
	/// <returns>
	/// An <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" /> of <see cref="T:Roblox.Platform.TranslationStorage.ITranslationForContentLocale" /> corresponding to the passed in information.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="contentVariantType" /> is not supported or <paramref name="contentSourceTargetId" /> is null or whitespace.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown in case there is any exception while attempting to get the translations from the storage service.</exception>
	IReadOnlyCollection<ITranslationForContentLocale> GetTranslationForContentLocales(ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId);

	/// <summary>
	/// Retrieves translation history for provided locale.
	/// </summary>
	/// <param name="supportedLocale">The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" />.</param>
	/// <param name="contentSourceType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentSourceType" />.</param>
	/// <param name="contentVariantType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentVariantType" />.</param>
	/// <param name="contentSourceTargetId">The content source target identifier.</param>
	/// <param name="exclusiveStartId">The exclusiveStartId.</param>
	/// <param name="count">The count of results.</param>
	/// <param name="sortOrder">The <see cref="T:Roblox.DataV2.Core.SortOrder" />.</param>
	/// <returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="supportedLocale" /> is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="contentVariantType" /> is not supported or <paramref name="contentSourceTargetId" /> is null or whitespaces or <paramref name="count" /> is less than one.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown in case there is any exception while attempting to get the translation history from the storage service.</exception>
	/// </returns>
	IGetTranslationHistoryResult GetTranslationHistory(ISupportedLocale supportedLocale, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string exclusiveStartId, int count, SortOrder sortOrder);

	/// <summary>
	/// Retrieves translation history for provided language.
	/// </summary>
	/// <param name="languageFamily">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" />.</param>
	/// <param name="contentSourceType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentSourceType" />.</param>
	/// <param name="contentVariantType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentVariantType" />.</param>
	/// <param name="contentSourceTargetId">The content source target identifier.</param>
	/// <param name="exclusiveStartId">The exclusiveStartId.</param>
	/// <param name="count">The count of results.</param>
	/// <param name="sortOrder">The <see cref="T:Roblox.DataV2.Core.SortOrder" />.</param>
	/// <returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="languageFamily" /> is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="contentVariantType" /> is not supported or <paramref name="contentSourceTargetId" /> is null or whitespaces or <paramref name="count" /> is less than one.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown in case there is any exception while attempting to get the translation history from the storage service.</exception>
	/// </returns>
	IGetTranslationHistoryResult GetTranslationHistory(ILanguageFamily languageFamily, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string exclusiveStartId, int count, SortOrder sortOrder);
}
