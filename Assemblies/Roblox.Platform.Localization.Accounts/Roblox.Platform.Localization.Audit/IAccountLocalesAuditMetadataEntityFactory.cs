using System.Collections.Generic;
using Roblox.Platform.Localization.Accounts;

namespace Roblox.Platform.Localization.Audit;

internal interface IAccountLocalesAuditMetadataEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAuditMetadataEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAuditMetadataEntity" /> with the given ID, or null if none existed.</returns>
	IAccountLocalesAuditMetadataEntity Get(long id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAuditMetadataEntity" />s by their AuditId and <see cref="T:Roblox.Platform.Localization.Accounts.AccountLocalesAuditEntryMetadataType" />.
	/// </summary>
	/// <param name="accountLocalesAuditEntryAuditId">The AccountLocales row ID.</param>
	/// <param name="accountLocalesAuditMetadataTypeId">The data that was changed. <see cref="T:Roblox.Platform.Localization.Accounts.AccountLocalesAuditEntryMetadataType" />.</param>
	/// <param name="count">The number of entities to get.</param>
	/// <param name="exclusiveStartId">The exclusive key at which to begin getting entities.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="count" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAuditMetadataEntity" />s.</returns>
	ICollection<IAccountLocalesAuditMetadataEntity> GetByAccountLocalesAuditEntryAuditIdAndAccountLocalesAuditMetadataTypeIdEnumerative(long accountLocalesAuditEntryAuditId, byte accountLocalesAuditMetadataTypeId, int count, long? exclusiveStartId = null);

	/// <summary>
	/// Creates a new <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAuditMetadataEntity" /> based on an <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAuditEntryEntity" />. 
	/// </summary>
	/// <param name="auditEntryEntity">The <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAuditEntryEntity" />.</param>
	/// <param name="metadataType">The <see cref="T:Roblox.Platform.Localization.Accounts.AccountLocalesAuditEntryMetadataType" />.</param>
	/// <param name="changeAgentType">The <see cref="T:Roblox.Platform.Localization.Accounts.AccountLocalesChangeAgentType" />.</param>
	/// <param name="changeAgentTargetId">The change agent type target Id.</param>
	/// <returns>A new <see cref="T:Roblox.Platform.Localization.Audit.IAccountLocalesAuditMetadataEntity" />.</returns>
	IAccountLocalesAuditMetadataEntity Create(IAccountLocalesAuditEntryEntity auditEntryEntity, AccountLocalesAuditEntryMetadataType metadataType, AccountLocalesChangeAgentType changeAgentType, long? changeAgentTargetId);
}
