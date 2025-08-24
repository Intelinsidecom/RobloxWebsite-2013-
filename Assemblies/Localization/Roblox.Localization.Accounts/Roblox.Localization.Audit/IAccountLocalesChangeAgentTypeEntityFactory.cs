namespace Roblox.Platform.Localization.Audit;

internal interface IAccountLocalesChangeAgentTypeEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesChangeAgentTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesChangeAgentTypeEntity" /> with the given ID, or null if none existed.</returns>
	IAccountLocalesChangeAgentTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesChangeAgentTypeEntity" /> with the given value.
	/// </summary>
	/// <param name="value">The value of the change agent type.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesChangeAgentTypeEntity" /> with the given value, or null if none existed.</returns>
	IAccountLocalesChangeAgentTypeEntity GetByValue(string value);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesChangeAgentTypeEntity" /> with the given value.
	/// </summary>
	/// <param name="value">The value of the change agent type.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesChangeAgentTypeEntity" /> with the given value.</returns>
	IAccountLocalesChangeAgentTypeEntity GetOrCreate(string value);
}
