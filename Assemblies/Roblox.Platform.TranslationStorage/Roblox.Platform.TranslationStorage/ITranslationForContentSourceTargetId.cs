namespace Roblox.Platform.TranslationStorage;

/// <summary>
/// An interface that holds a translation.
/// </summary>
public interface ITranslationForContentSourceTargetId
{
	/// <summary>
	/// Gets the content source target identifier.
	/// </summary>
	/// <value>
	/// The content source target identifier.
	/// </value>
	string ContentSourceTargetId { get; }

	/// <summary>
	/// Gets the translation value.
	/// </summary>
	/// <value>
	/// The translation value.
	/// </value>
	string TranslationValue { get; }
}
