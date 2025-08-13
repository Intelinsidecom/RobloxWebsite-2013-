namespace Roblox.Platform.TranslationStorage;

/// <summary>
/// An interface that holds translations for ContentLocales.
/// </summary>
public interface ITranslationForContentLocale
{
	/// <summary>
	/// Gets the content locale.
	/// </summary>
	/// <value>
	/// The content locale.
	/// </value>
	string ContentLocale { get; }

	/// <summary>
	/// Gets the translated value.
	/// </summary>
	/// <value>
	/// The translated value.
	/// </value>
	string TranslationValue { get; }
}
