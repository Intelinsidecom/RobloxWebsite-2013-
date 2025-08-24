namespace Roblox.Platform.Localization.Audit;

internal interface IAccountCountriesChangeAgentTypeEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesChangeAgentTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesChangeAgentTypeEntity" /> with the given ID, or null if none existed.</returns>
	IAccountCountriesChangeAgentTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesChangeAgentTypeEntity" /> with the given value.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesChangeAgentTypeEntity" /> with the given value, or null if none existed.</returns>
	IAccountCountriesChangeAgentTypeEntity GetByValue(string value);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesChangeAgentTypeEntity" /> with the given value.
	/// </summary>
	/// <param name="value">The value to get or create.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesChangeAgentTypeEntity" /> with the given value.</returns>
	IAccountCountriesChangeAgentTypeEntity GetOrCreate(string value);
}
