using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Assets.Entities;

internal class AssetVersionMetadata : IRobloxEntity<long, AssetVersionMetadataDAL>, ICacheableObject<long>, ICacheableObject
{
	private AssetVersionMetadataDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AssetVersionMetadata).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long AssetVersionID
	{
		get
		{
			return _EntityDAL.AssetVersionID;
		}
		set
		{
			_EntityDAL.AssetVersionID = value;
		}
	}

	internal string Hash
	{
		get
		{
			return _EntityDAL.Hash;
		}
		set
		{
			_EntityDAL.Hash = value;
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

	internal DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		set
		{
			_EntityDAL.Updated = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AssetVersionMetadata()
	{
		_EntityDAL = new AssetVersionMetadataDAL();
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
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	internal static AssetVersionMetadata Get(long id)
	{
		return EntityHelper.GetEntity<long, AssetVersionMetadataDAL, AssetVersionMetadata>(EntityCacheInfo, id, () => AssetVersionMetadataDAL.Get(id));
	}

	private static ICollection<AssetVersionMetadata> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AssetVersionMetadataDAL, AssetVersionMetadata>(ids, EntityCacheInfo, AssetVersionMetadataDAL.MultiGet);
	}

	public static AssetVersionMetadata GetByAssetVersionID(long assetVersionID)
	{
		return EntityHelper.GetEntityByLookup<long, AssetVersionMetadataDAL, AssetVersionMetadata>(EntityCacheInfo, GetLookupCacheKeysByAssetVersionID(assetVersionID), () => AssetVersionMetadataDAL.GetAssetVersionMetadataByAssetVersionID(assetVersionID));
	}

	public static AssetVersionMetadata GetOrCreate(long assetVersionID)
	{
		return EntityHelper.GetOrCreateEntity<long, AssetVersionMetadata>(EntityCacheInfo, GetLookupCacheKeysByAssetVersionID(assetVersionID), () => DoGetOrCreate(assetVersionID));
	}

	private static AssetVersionMetadata DoGetOrCreate(long assetVersionID)
	{
		return EntityHelper.DoGetOrCreate<long, AssetVersionMetadataDAL, AssetVersionMetadata>(() => AssetVersionMetadataDAL.GetOrCreateAssetVersionMetadata(assetVersionID));
	}

	public void Construct(AssetVersionMetadataDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByAssetVersionID(AssetVersionID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeysByAssetVersionID(long assetVersionID)
	{
		return $"AssetVersionID:{assetVersionID}";
	}
}
