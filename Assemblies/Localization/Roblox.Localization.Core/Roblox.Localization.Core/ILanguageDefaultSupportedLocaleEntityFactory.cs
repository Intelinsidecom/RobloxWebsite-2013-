namespace Roblox.Platform.Localization.Core;

internal interface ILanguageDefaultSupportedLocaleEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Localization.Core.ILanguageDefaultSupportedLocaleEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Core.ILanguageDefaultSupportedLocaleEntity" /> with the given ID, or null if none existed.</returns>
	ILanguageDefaultSupportedLocaleEntity Get(int id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Localization.Core.ILanguageDefaultSupportedLocaleEntity" /> with the given language id.
	/// </summary>
	/// <param name="languageId">The language id.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Core.ILanguageDefaultSupportedLocaleEntity" /> with the given languageId, or null if none existed.</returns>
	ILanguageDefaultSupportedLocaleEntity GetByLanguageId(int languageId);

	/// <summary>
	/// Create instance of <see cref="T:Roblox.Platform.Localization.Core.ILanguageDefaultSupportedLocaleEntity" /> with given language id and supported locale id.
	/// </summary>
	/// <param name="languageId">language id must positive and present in valid list of languages</param>
	/// <param name="supportedLocaleId">supported locale is must be positive and present in valid list of supported locales</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Core.ILanguageDefaultSupportedLocaleEntity" /> with given language id and supported locale id </returns>
	ILanguageDefaultSupportedLocaleEntity Create(int languageId, int supportedLocaleId);
}
