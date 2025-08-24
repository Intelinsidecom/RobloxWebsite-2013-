using System.Collections.Generic;
using Roblox.Platform.Localization.Accounts;

namespace Roblox.Platform.Localization.Audit;

internal interface IAccountCountriesAuditMetadataEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditMetadataEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditMetadataEntity" /> with the given ID, or null if none existed.</returns>
	IAccountCountriesAuditMetadataEntity Get(long id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditMetadataEntity" />s by their AuditId and <see cref="T:Roblox.Platform.Localization.Accounts.AccountCountriesAuditEntryMetadataType" />.
	/// </summary>
	/// <param name="accountCountriesAuditEntryAuditId">The AccountCountries row ID.</param>
	/// <param name="accountCountriesAuditMetadataTypeId">The data that was changed. <see cref="T:Roblox.Platform.Localization.Accounts.AccountCountriesAuditEntryMetadataType" />.</param>
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartId">The exclusive key at which to begin getting entities.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditMetadataEntity" />s.</returns>
	IReadOnlyCollection<IAccountCountriesAuditMetadataEntity> GetByAccountCountriesAuditEntryAuditIdAndAccountCountriesAuditMetadataTypeIdEnumerative(long accountCountriesAuditEntryAuditId, byte accountCountriesAuditMetadataTypeId, int count, long? exclusiveStartId = null);

	/// <summary>
	/// Creates a new <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditMetadataEntity" /> based on an <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditEntryEntity" />.
	/// </summary>
	/// <param name="auditEntryEntity">The <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditEntryEntity" />.</param>
	/// <param name="metadataType">The <see cref="T:Roblox.Platform.Localization.Accounts.AccountCountriesAuditEntryMetadataType" />.</param>
	/// <param name="changeAgentType">The <see cref="T:Roblox.Platform.Localization.Audit.AccountCountriesChangeAgentTypeCAL" />.</param>
	/// <param name="changeAgentTargetId">The change agent type target Id.</param>
	/// <returns>A new <see cref="T:Roblox.Platform.Localization.Audit.IAccountCountriesAuditMetadataEntity" />.</returns>
	IAccountCountriesAuditMetadataEntity Create(IAccountCountriesAuditEntryEntity auditEntryEntity, AccountCountriesAuditEntryMetadataType metadataType, AccountCountriesChangeAgentType changeAgentType, long? changeAgentTargetId);
}
