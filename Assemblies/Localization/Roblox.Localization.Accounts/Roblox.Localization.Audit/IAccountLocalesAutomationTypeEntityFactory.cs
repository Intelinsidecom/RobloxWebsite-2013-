namespace Roblox.Platform.Localization.Audit;

internal interface IAccountLocalesAutomationTypeEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAutomationTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAutomationTypeEntity" /> with the given ID, or null if none existed.</returns>
	IAccountLocalesAutomationTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAutomationTypeEntity" /> with the given value.
	/// </summary>
	/// <param name="value">The value of the automation type.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAutomationTypeEntity" /> with the given value, or null if none existed.</returns>
	IAccountLocalesAutomationTypeEntity GetByValue(string value);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAutomationTypeEntity" /> with the given value.
	/// </summary>
	/// <param name="value">The value of the automation type.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAutomationTypeEntity" /> with the given value.</returns>
	IAccountLocalesAutomationTypeEntity GetOrCreate(string value);
}
