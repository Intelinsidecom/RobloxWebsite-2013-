namespace Roblox.Platform.TranslationStorage;

/// <summary>
/// Status for CreateOrUpdateTranslation operation to tell if the translation was created or updated.
/// </summary>
public enum CreateOrUpdateTranslationStatus
{
	/// <summary>
	/// The translation was created.
	/// </summary>
	Created = 1,
	/// <summary>
	/// The translation was updated.
	/// </summary>
	Updated
}
