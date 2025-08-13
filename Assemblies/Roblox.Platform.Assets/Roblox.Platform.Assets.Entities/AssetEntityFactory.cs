using System;
using Roblox.Agents;
using Roblox.Platform.Assets.Entities.AssetHash;
using Roblox.Platform.Assets.Entities.Audit;
using Roblox.Platform.Assets.Properties;
using Roblox.Platform.Core;

namespace Roblox.Platform.Assets.Entities;

internal class AssetEntityFactory : DomainObjectBase<AssetDomainFactories>, IAssetEntityFactory
{
	internal virtual bool IsAuditingEnabled => Settings.Default.IsAssetsTableAuditingEnabled;

	public AssetEntityFactory(AssetDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	public IAssetEntity Get(long id)
	{
		Roblox.Asset cal = Roblox.Asset.Get(id);
		return CalToCachedMssql(cal);
	}

	public IAssetEntity MustGet(long id)
	{
		IAssetEntity assetEntity = Get(id);
		return assetEntity ?? throw new InvalidOperationException("Attempted get on unpersisted entity.");
	}

	private IAssetEntity CalToCachedMssql(Roblox.Asset cal)
	{
		if (cal != null)
		{
			return new AssetEntity
			{
				Id = cal.ID,
				TypeId = cal.AssetTypeID,
				Name = cal.Name,
				Description = cal.Description,
				Created = cal.Created,
				Updated = cal.Updated,
				AssetGenres = cal.AssetGenres,
				AssetCategories = cal.AssetCategories,
				CreatorId = cal.CreatorID,
				_EntityDAL = cal._EntityDAL,
				DomainFactories = base.DomainFactories
			};
		}
		return null;
	}

	public DataUpdateResult<IAssetEntity, IAssetsAuditEntryEntity> Create(Roblox.AssetType assetTypeEntity, IAssetHashEntity assetHash, ITrustedAssetTextInfo trustedAssetTextInfo, IAgent creatorAgent)
	{
		Roblox.Asset cal = new Roblox.Asset
		{
			CreatorID = creatorAgent.Id,
			AssetTypeID = assetTypeEntity.ID,
			AssetHashID = assetHash.Id,
			Hash = assetHash.Hash,
			Name = trustedAssetTextInfo.Name,
			Description = trustedAssetTextInfo.Description,
			CurrentVersionID = 0L
		};
		cal.Save();
		IAssetEntity entity = CalToCachedMssql(cal);
		IAssetsAuditEntryEntity auditEntryEntity = null;
		if (IsAuditingEnabled)
		{
			auditEntryEntity = base.DomainFactories.AssetsAuditEntriesEntityFactory.Create(entity._EntityDAL);
		}
		return new DataUpdateResult<IAssetEntity, IAssetsAuditEntryEntity>(entity, auditEntryEntity);
	}
}
