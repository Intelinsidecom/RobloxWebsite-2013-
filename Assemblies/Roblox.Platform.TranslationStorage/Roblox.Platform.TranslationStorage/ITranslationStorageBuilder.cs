using System.Collections.Generic;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.TranslationStorage;

/// <summary>
/// An interface that creates and updates translations to the Translation Storage service.
/// </summary>
public interface ITranslationStorageBuilder
{
	/// <summary>
	/// Creates the translation for the provided arguments.
	/// </summary>
	/// <param name="supportedLocale">The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" />.</param>
	/// <param name="contentSourceType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentSourceType" />.</param>
	/// <param name="contentVariantType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentVariantType" /> of the translation.</param>
	/// <param name="contentSourceTargetId">The content source target identifier.</param>
	/// <param name="translationValue">The translation value.</param>
	/// <param name="isSourceContentVariantAndLocale">if set to <c>true</c> [is source content variant and locale].</param>
	/// <param name="changeAgent">The <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgent" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="supportedLocale" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="contentVariantType" />  is not supported or <paramref name="contentSourceTargetId" /> or <paramref name="translationValue" /> is null or empty.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown in case there is any exception while attempting to upload the translation to the storage service.</exception>
	void CreateTranslation(ISupportedLocale supportedLocale, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string translationValue, bool isSourceContentVariantAndLocale = false, IChangeAgent changeAgent = null);

	/// <summary>
	/// Creates the translation for the provided arguments.
	/// </summary>
	/// <param name="languageFamily">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" />.</param>
	/// <param name="contentSourceType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentSourceType" />.</param>
	/// <param name="contentVariantType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentVariantType" /> of the translation.</param>
	/// <param name="contentSourceTargetId">The content source target identifier.</param>
	/// <param name="translationValue">The translation value.</param>
	/// <param name="isSourceContentVariantAndLocale">if set to <c>true</c> [is source content variant and locale].</param>
	/// <param name="changeAgent">The <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgent" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="languageFamily" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="contentVariantType" />  is not supported or <paramref name="contentSourceTargetId" /> or <paramref name="translationValue" /> is null or empty.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown in case there is any exception while attempting to upload the translation to the storage service.</exception>
	void CreateTranslation(ILanguageFamily languageFamily, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string translationValue, bool isSourceContentVariantAndLocale = false, IChangeAgent changeAgent = null);

	/// <summary>
	/// Creates a new translation for the provided arguments or updates an existing translation.
	/// </summary>
	/// <param name="supportedLocale">The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" />.</param>
	/// <param name="contentSourceType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentSourceType" />.</param>
	/// <param name="contentVariantType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentVariantType" /> of the translation.</param>
	/// <param name="contentSourceTargetId">The content source target identifier.</param>
	/// <param name="translationValue">The translation value.</param>
	/// <param name="isSourceContentVariantAndLocale">if set to <c>true</c> [is source content variant and locale].</param>
	/// <param name="changeAgent">The <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgent" />.</param>
	/// <returns><see cref="T:Roblox.Platform.TranslationStorage.CreateOrUpdateTranslationStatus" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="supportedLocale" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="contentVariantType" />  is not supported or <paramref name="contentSourceTargetId" /> or <paramref name="translationValue" /> is null or empty.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown in case there is any exception while attempting to upload the translation to the storage service.</exception>
	CreateOrUpdateTranslationStatus CreateOrUpdateTranslation(ISupportedLocale supportedLocale, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string translationValue, bool isSourceContentVariantAndLocale = false, IChangeAgent changeAgent = null);

	/// <summary>
	/// Creates a new translation for the provided arguments or updates an existing translation.
	/// </summary>
	/// <param name="languageFamily">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" />.</param>
	/// <param name="contentSourceType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentSourceType" />.</param>
	/// <param name="contentVariantType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentVariantType" /> of the translation.</param>
	/// <param name="contentSourceTargetId">The content source target identifier.</param>
	/// <param name="translationValue">The translation value.</param>
	/// <param name="isSourceContentVariantAndLocale">if set to <c>true</c> [is source content variant and locale].</param>
	/// <param name="changeAgent">The <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgent" />.</param>
	/// <returns><see cref="T:Roblox.Platform.TranslationStorage.CreateOrUpdateTranslationStatus" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="languageFamily" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="contentVariantType" />  is not supported or <paramref name="contentSourceTargetId" /> or <paramref name="translationValue" /> is null or empty.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown in case there is any exception while attempting to upload the translation to the storage service.</exception>
	CreateOrUpdateTranslationStatus CreateOrUpdateTranslation(ILanguageFamily languageFamily, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string translationValue, bool isSourceContentVariantAndLocale = false, IChangeAgent changeAgent = null);

	/// <summary>
	/// Deletes the translation for the provided arguments.
	/// </summary>
	/// <param name="supportedLocale">The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" />.</param>
	/// <param name="contentSourceType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentSourceType" />.</param>
	/// <param name="contentVariantType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentVariantType" />.</param>
	/// <param name="contentSourceTargetId">The content source target identifier.</param>
	/// <param name="changeAgent">The <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgent" />.</param>
	/// <returns><see cref="T:Roblox.Platform.TranslationStorage.DeleteTranslationResponse" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="supportedLocale" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="contentVariantType" />  is not supported or <paramref name="contentSourceTargetId" /> is null or empty.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown in case there is any exception while attempting to upload the translation to the storage service.</exception>
	DeleteTranslationResponse DeleteTranslation(ISupportedLocale supportedLocale, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, IChangeAgent changeAgent = null);

	/// <summary>
	/// Deletes the translation for the provided arguments.
	/// </summary>
	/// <param name="languageFamily">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" />.</param>
	/// <param name="contentSourceType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentSourceType" />.</param>
	/// <param name="contentVariantType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentVariantType" />.</param>
	/// <param name="contentSourceTargetId">The content source target identifier.</param>
	/// <param name="changeAgent">The <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgent" />.</param>
	/// <returns><see cref="T:Roblox.Platform.TranslationStorage.DeleteTranslationResponse" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="languageFamily" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="contentVariantType" />  is not supported or <paramref name="contentSourceTargetId" /> is null or empty.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown in case there is any exception while attempting to upload the translation to the storage service.</exception>
	DeleteTranslationResponse DeleteTranslation(ILanguageFamily languageFamily, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, IChangeAgent changeAgent = null);

	/// <summary>
	/// Updates the translation for the provided arguments.
	/// </summary>
	/// <param name="supportedLocale">The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" />.</param>
	/// <param name="contentSourceType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentSourceType" />.</param>
	/// <param name="contentVariantType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentVariantType" /> of the translation.</param>
	/// <param name="contentSourceTargetId">The content source target identifier.</param>
	/// <param name="translationValue">The translation value.</param>
	/// <param name="changeAgent">The <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgent" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="supportedLocale" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="contentVariantType" />  is not supported or <paramref name="contentSourceTargetId" /> or <paramref name="translationValue" /> is null or empty.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown in case there is any exception while attempting to upload the translation to the storage service.</exception>
	void UpdateTranslation(ISupportedLocale supportedLocale, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string translationValue, IChangeAgent changeAgent = null);

	/// <summary>
	/// Updates the translation for the provided arguments.
	/// </summary>
	/// <param name="languageFamily">The <see cref="T:Roblox.Platform.Localization.Core.ILanguageFamily" />.</param>
	/// <param name="contentSourceType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentSourceType" />.</param>
	/// <param name="contentVariantType">The <see cref="T:Roblox.Platform.TranslationStorage.ContentVariantType" /> of the translation.</param>
	/// <param name="contentSourceTargetId">The content source target identifier.</param>
	/// <param name="translationValue">The translation value.</param>
	/// <param name="changeAgent">The <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgent" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="languageFamily" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="contentVariantType" />  is not supported or <paramref name="contentSourceTargetId" /> or <paramref name="translationValue" /> is null or empty.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown in case there is any exception while attempting to upload the translation to the storage service.</exception>
	void UpdateTranslation(ILanguageFamily languageFamily, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string translationValue, IChangeAgent changeAgent = null);

	/// <summary>
	/// Migrates a translation and its retained created history. Deletes the old translations and history afterwards
	/// </summary>
	/// <param name="migrateTranslationIds"></param>
	/// <param name="contentSourceType"></param>
	/// <param name="contentVariantType"></param>
	void MigrateTranslations(IEnumerable<MigrateTranslationId> migrateTranslationIds, ContentSourceType contentSourceType, ContentVariantType contentVariantType);
}
