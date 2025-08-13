using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Assets.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AssetsAuditMetadataCAL : IRobloxEntity<long, AssetsAuditMetadataDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private AssetsAuditMetadataDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AssetsAuditMetadataCAL).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal Guid AssetsAuditEntryPublicID
	{
		get
		{
			return _EntityDAL.AssetsAuditEntryPublicID;
		}
		set
		{
			_EntityDAL.AssetsAuditEntryPublicID = value;
		}
	}

	internal long AssetID
	{
		get
		{
			return _EntityDAL.AssetID;
		}
		set
		{
			_EntityDAL.AssetID = value;
		}
	}

	internal long? ActorUserID
	{
		get
		{
			return _EntityDAL.ActorUserID;
		}
		set
		{
			_EntityDAL.ActorUserID = value;
		}
	}

	internal byte AssetChangeTypeID
	{
		get
		{
			return _EntityDAL.AssetChangeTypeID;
		}
		set
		{
			_EntityDAL.AssetChangeTypeID = value;
		}
	}

	internal bool IsLegacyValue
	{
		get
		{
			return _EntityDAL.IsLegacyValue;
		}
		set
		{
			_EntityDAL.IsLegacyValue = value;
		}
	}

	internal DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		set
		{
			_EntityDAL.Created = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AssetsAuditMetadataCAL()
	{
		_EntityDAL = new AssetsAuditMetadataDAL();
	}

	public AssetsAuditMetadataCAL(AssetsAuditMetadataDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	internal static AssetsAuditMetadataCAL Get(long id)
	{
		return EntityHelper.GetEntity<long, AssetsAuditMetadataDAL, AssetsAuditMetadataCAL>(EntityCacheInfo, id, () => AssetsAuditMetadataDAL.Get(id));
	}

	internal static ICollection<AssetsAuditMetadataCAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AssetsAuditMetadataDAL, AssetsAuditMetadataCAL>(ids, EntityCacheInfo, AssetsAuditMetadataDAL.MultiGet);
	}

	internal static ICollection<AssetsAuditMetadataCAL> GetAssetsAuditMetadataByAssetIDAndAssetChangeTypeID(long assetId, byte assetChangeTypeId, int count, long? exclusiveStartId)
	{
		string collectionId = $"GetAssetsAuditMetadataByAssetIDAndAssetChangeTypeID_AssetID:{assetId}_AssetChangeTypeID:{assetChangeTypeId}_Count:{count}_ExclusiveStartID:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByAssetIDAssetChangeTypeID(assetId, assetChangeTypeId)), collectionId, () => AssetsAuditMetadataDAL.GetAssetsAuditMetadataIDsByAssetIDAndAssetChangeTypeID(assetId, assetChangeTypeId, count, exclusiveStartId), MultiGet);
	}

	public void Construct(AssetsAuditMetadataDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByAssetIDAssetChangeTypeID(AssetID, AssetChangeTypeID));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByID(long id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByAssetIDAssetChangeTypeID(long assetId, byte assetChangeTypeId)
	{
		return $"AssetID:{assetId}_AssetChangeTypeID:{assetChangeTypeId}";
	}
}
