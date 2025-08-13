using System.Collections.Generic;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets.Entities.Audit;

internal interface IAssetsAuditMetadataEntityFactory : IDomainFactory<AssetDomainFactories>, IDomainObject<AssetDomainFactories>
{
	/// <summary>
	/// Creates a new Metadata record for the audit entry based on the information provided.
	/// </summary>
	IAssetsAuditMetadataEntity CreateNew(IAssetsAuditEntryEntity auditEntity, AssetChangeType changeType, IUserIdentifier actorUserIdentity);

	/// <summary>
	/// Creates a Metadata record for a legacy audit entry from a time period when auditing was not turned on.
	/// </summary>
	IAssetsAuditMetadataEntity CreateLegacyAudit(IAssetsAuditEntryEntity auditEntity, AssetChangeType changeType);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Assets.Entities.Audit.IAssetsAuditMetadataEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Assets.Entities.Audit.IAssetsAuditMetadataEntity" /> with the given ID, or null if none existed.</returns>
	IAssetsAuditMetadataEntity Get(long id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Assets.Entities.Audit.IAssetsAuditMetadataEntity" />s by their assetId and assetChangeTypeId, paged by their Id in Descending order
	/// </summary>
	/// <returns>The page of <see cref="T:Roblox.Platform.Assets.Entities.Audit.IAssetsAuditMetadataEntity" />s.</returns>
	IEnumerable<IAssetsAuditMetadataEntity> GetByAssetIdAndAssetChangeTypeIdEnumerative(long assetId, byte assetChangeTypeId, int count, long? exclusiveStartId = null);
}
