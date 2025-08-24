using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AssetsAuditMetadataEntityFactory : IAssetsAuditMetadataEntityFactory, IDomainFactory<AssetDomainFactories>, IDomainObject<AssetDomainFactories>
{
	public AssetDomainFactories DomainFactories { get; }

	public IAssetsAuditMetadataEntity CreateNew(IAssetsAuditEntryEntity auditEntity, AssetChangeType changeType, IUserIdentifier actorUserIdentity)
	{
		byte changeTypeId = DomainFactories.AssetChangeTypesEntityFactory.GetIdByEnum(changeType);
		return Create(auditEntity, changeTypeId, isLegacyValue: false, actorUserIdentity);
	}

	public IAssetsAuditMetadataEntity CreateLegacyAudit(IAssetsAuditEntryEntity auditEntity, AssetChangeType changeType)
	{
		byte changeTypeId = DomainFactories.AssetChangeTypesEntityFactory.GetIdByEnum(changeType);
		return Create(auditEntity, changeTypeId, isLegacyValue: true, null);
	}

	internal IAssetsAuditMetadataEntity Create(IAssetsAuditEntryEntity auditEntity, byte changeTypeId, bool isLegacyValue, IUserIdentifier actorUserIdentity)
	{
		AssetsAuditMetadataCAL assetsAuditMetadataCAL = new AssetsAuditMetadataCAL();
		assetsAuditMetadataCAL.ActorUserID = actorUserIdentity?.Id;
		assetsAuditMetadataCAL.AssetChangeTypeID = changeTypeId;
		assetsAuditMetadataCAL.AssetID = auditEntity.Audit_Id;
		assetsAuditMetadataCAL.AssetsAuditEntryPublicID = auditEntity.PublicId;
		assetsAuditMetadataCAL.IsLegacyValue = isLegacyValue;
		assetsAuditMetadataCAL.Save();
		return CalToCachedMssql(assetsAuditMetadataCAL);
	}

	public AssetsAuditMetadataEntityFactory(AssetDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IAssetsAuditMetadataEntity Get(long id)
	{
		return CalToCachedMssql(AssetsAuditMetadataCAL.Get(id));
	}

	public IEnumerable<IAssetsAuditMetadataEntity> GetByAssetIdAndAssetChangeTypeIdEnumerative(long assetId, byte assetChangeTypeId, int count, long? exclusiveStartId = null)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return AssetsAuditMetadataCAL.GetAssetsAuditMetadataByAssetIDAndAssetChangeTypeID(assetId, assetChangeTypeId, count, exclusiveStartId).Select(CalToCachedMssql);
	}

	private static IAssetsAuditMetadataEntity CalToCachedMssql(AssetsAuditMetadataCAL cal)
	{
		if (cal != null)
		{
			return new AssetsAuditMetadataEntity
			{
				Id = cal.ID,
				AssetsAuditEntryPublicId = cal.AssetsAuditEntryPublicID,
				AssetId = cal.AssetID,
				ActorUserId = cal.ActorUserID,
				AssetChangeTypeId = cal.AssetChangeTypeID,
				IsLegacyValue = cal.IsLegacyValue,
				Created = cal.Created
			};
		}
		return null;
	}
}
