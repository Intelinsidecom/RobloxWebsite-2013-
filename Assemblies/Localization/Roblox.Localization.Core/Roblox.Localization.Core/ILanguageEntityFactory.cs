namespace Roblox.Platform.Localization.Core;

internal interface ILanguageEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Localization.Core.ILanguageEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Core.ILanguageEntity" /> with the given ID, or null if none existed.</returns>
	ILanguageEntity Get(int id);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Localization.Core.ILanguageEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Core.ILanguageEntity" /> with the given ID, or null if none existed.</returns>
	ILanguageEntity Get(ILanguageFamilyIdentifier id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Localization.Core.ILanguageEntity" /> with the given language name
	/// </summary>
	/// <param name="name">Language name.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Core.ILanguageEntity" /> with the given language name, or null if none existed.</returns>
	ILanguageEntity GetByName(string name);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Localization.Core.ILanguageEntity" /> with the given language code.
	/// </summary>
	/// <param name="languageCode">Language code.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Core.ILanguageEntity" /> language code or null if none existed.</returns>
	ILanguageEntity GetByLanguageCode(string languageCode);

	/// <summary>
	/// Create language by name, native name and language code.
	/// </summary>
	/// <param name="name">name of the language, example - korean </param>
	/// <param name="nativeName">native name of the language, example - 한국어 </param>
	/// <param name="languageCode">language code, example - ko </param>
	/// <returns></returns>
	ILanguageEntity Create(string name, string nativeName, string languageCode);
}
