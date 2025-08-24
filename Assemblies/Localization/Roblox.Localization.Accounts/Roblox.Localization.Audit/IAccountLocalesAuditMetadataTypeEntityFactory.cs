namespace Roblox.Platform.Localization.Audit;

internal interface IAccountLocalesAuditMetadataTypeEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAuditMetadataTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAuditMetadataTypeEntity" /> with the given ID, or null if none existed.</returns>
	IAccountLocalesAuditMetadataTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAuditMetadataTypeEntity" /> with the given TODO: Fill in characteristics.
	/// </summary>
	/// TODO: Fill in params
	/// TODO: Fill in exceptions
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAuditMetadataTypeEntity" /> with the given TODO: Fill in characteristics, or null if none existed.</returns>
	IAccountLocalesAuditMetadataTypeEntity GetByValue(string value);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAuditMetadataTypeEntity" /> with the given TODO: Fill in characteristics.
	/// </summary>
	/// TODO: Add other params.
	/// TODO: Add exceptions.
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAuditMetadataTypeEntity" /> with the given TODO: Fill in characterisics.</returns>
	IAccountLocalesAuditMetadataTypeEntity GetOrCreate(string value);
}
