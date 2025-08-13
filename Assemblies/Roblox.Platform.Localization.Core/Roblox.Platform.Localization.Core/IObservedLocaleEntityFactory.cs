namespace Roblox.Platform.Localization.Core;

internal interface IObservedLocaleEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Localization.Core.IObservedLocaleEntity" /> by ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Core.IObservedLocaleEntity" /> with the given ID, or null if none existed.</returns>
	IObservedLocaleEntity Get(int id);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Localization.Core.IObservedLocaleEntity" /> by observed locale id .
	/// </summary>
	/// <param name="identifier">Id</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Core.IObservedLocaleEntity" /> with the given ID, or null if none existed.</returns>
	IObservedLocaleEntity Get(IDeviceReportedLocaleIdentifier identifier);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Localization.Core.IObservedLocaleEntity" /> with the given locale.
	/// </summary>
	/// <param name="locale">locale</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Core.IObservedLocaleEntity" /> with the given locale, or null if non existed.</returns>
	IObservedLocaleEntity GetByLocale(string locale);

	/// <summary>
	/// Creates the <see cref="T:Roblox.Platform.Localization.Core.IObservedLocaleEntity" /> with given locale, language id and supported locale id
	/// </summary>
	/// <param name="locale">example ko-ko</param>
	/// <param name="languageId">language associated with given locale</param>
	/// <param name="supportedLocaleId">supported locale associated with give locale</param>
	/// <returns></returns>
	IObservedLocaleEntity Create(string locale, int? languageId, int? supportedLocaleId);
}
