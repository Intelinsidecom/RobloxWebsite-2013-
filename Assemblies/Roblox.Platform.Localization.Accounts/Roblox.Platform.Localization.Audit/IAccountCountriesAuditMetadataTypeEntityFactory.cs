namespace Roblox.Platform.Localization.Audit;

internal interface IAccountCountriesAuditMetadataTypeEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditMetadataTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditMetadataTypeEntity" /> with the given ID, or null if none existed.</returns>
	IAccountCountriesAuditMetadataTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditMetadataTypeEntity" /> with the given value.
	/// </summary>
	/// TODO: Fill in params
	/// TODO: Fill in exceptions
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditMetadataTypeEntity" /> with the given value, or null if none existed.</returns>
	IAccountCountriesAuditMetadataTypeEntity GetByValue(string value);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditMetadataTypeEntity" /> with the given value.
	/// </summary>
	/// TODO: Add other params.
	/// TODO: Add exceptions.
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditMetadataTypeEntity" /> with the given value.</returns>
	IAccountCountriesAuditMetadataTypeEntity GetOrCreate(string value);
}
