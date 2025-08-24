namespace Roblox.Platform.TranslationStorage;

/// <summary>
/// A class that contains information like content locale, translation etc.
/// </summary>
public class TranslationValue
{
	/// <summary>
	/// What locale the translation is in.
	/// </summary>
	public string ContentLocale { get; }

	/// <summary>
	/// The translation
	/// </summary>
	public string Translation { get; }

	/// <summary>
	/// The constructor.
	/// </summary>
	/// <param name="contentLocale"></param>
	/// <param name="translation"></param>
	public TranslationValue(string contentLocale, string translation)
	{
		ContentLocale = contentLocale;
		Translation = translation;
	}
}
