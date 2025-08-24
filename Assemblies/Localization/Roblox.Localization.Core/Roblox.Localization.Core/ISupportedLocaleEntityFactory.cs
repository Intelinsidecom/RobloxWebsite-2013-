using System.Collections.Generic;

namespace Roblox.Platform.Localization.Core;

internal interface ISupportedLocaleEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocaleEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocaleEntity" /> with the given ID, or null if none existed.</returns>
	ISupportedLocaleEntity Get(int id);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocaleEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocaleEntity" /> with the given ID, or null if none existed.</returns>
	ISupportedLocaleEntity Get(ISupportedLocaleIdentifier id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocaleEntity" /> with the given locale.
	/// </summary>
	/// <param name="locale"></param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocaleEntity" /> with the given.</returns>
	ISupportedLocaleEntity GetByLocale(string locale);

	/// <summary>
	/// Creates the <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocaleEntity" /> with given locale, name, native name and language id
	/// </summary>
	/// <param name="locale">example ko-ko</param>
	/// <param name="name">example korean</param>
	/// <param name="nativeName">example 한국어 </param>
	/// <param name="languageId">Valid language associated with locale. Id must be from valid list of language ids.</param>
	/// <returns></returns>
	ISupportedLocaleEntity Create(string locale, string name, string nativeName, int languageId);

	/// <summary>
	/// Gets list of <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocaleEntity" />s from start row index with number of rows
	/// </summary>
	/// <param name="startRowIndex">The zero-indexed start row index at which to begin getting rows.</param>
	/// <param name="maxRows">The maximum number of rows to get.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="startRowIndex" /> is less than 0.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="maxRows" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocaleEntity" />s.</returns>
	IEnumerable<ISupportedLocaleEntity> GetSupportedLocalesPaged(int startRowIndex, int maxRows);
}
