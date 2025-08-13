using System.Collections.Generic;

namespace Roblox.Platform.TranslationStorage;

/// <summary>
/// A generic accessor for hitting the TranslationStorage service with shadow roll-out logic.
/// </summary>
/// <typeparam name="TIdentifier">The type of the identifier.</typeparam>
public interface IGenericTranslationStorageAccessor<TIdentifier>
{
	/// <summary>
	/// Gets the translation value from the service or the source string if it is not present.
	/// </summary>
	/// <param name="valueSource">The <see cref="T:Roblox.Platform.TranslationStorage.ValueSource`1" />.</param>
	/// <param name="contentSourceType">The content source type.</param>
	/// <param name="contentVariantType">The content variant type.</param>
	/// <param name="contentLocaleType">The content locale type.</param>
	/// <returns>
	/// A translation value or the source string.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">valueSource</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">contentSourceType</exception>
	string GetTranslationValue(ValueSource<TIdentifier> valueSource, string contentSourceType, string contentVariantType, string contentLocaleType);

	/// <summary>
	/// Multi-get translation values from the service or source strings.
	/// </summary>
	/// <param name="valueSources">The <see cref="T:System.Collections.Generic.ICollection`1" /> of <see cref="T:Roblox.Platform.TranslationStorage.ValueSource`1" />.</param>
	/// <param name="contentSourceType">The content source type.</param>
	/// <param name="contentVariantType">The content variant type.</param>
	/// <param name="contentLocaleType">The content locale type.</param>
	/// <returns>
	/// An <see cref="T:System.Collections.Generic.IDictionary`2" /> of <typeparamref name="TIdentifier" /> and its translationValue from the service or source string.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">valueSource</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">contentSourceType</exception>
	IReadOnlyDictionary<TIdentifier, string> MultiGetTranslationValues(ICollection<ValueSource<TIdentifier>> valueSources, string contentSourceType, string contentVariantType, string contentLocaleType);

	/// <summary>
	/// Gets the translation values in all locales. This also indicates whether the value is a source string or not.
	/// </summary>
	/// <param name="sourceLocale">The source locale.</param>
	/// <param name="contentSourceType">The content source type.</param>
	/// <param name="contentVariantType">The content variant type.</param>
	/// <param name="contentSourceTargetId">The content source target identifier.</param>
	/// <returns>
	/// An <see cref="T:System.Collections.Generic.IReadOnlyCollection`1" /> of <see cref="T:Roblox.Platform.TranslationStorage.TranslationValue" />.
	/// </returns>
	IReadOnlyCollection<TranslationValue> GetTranslationValuesInAllContentLocales(string sourceLocale, string contentSourceType, string contentVariantType, string contentSourceTargetId);
}
