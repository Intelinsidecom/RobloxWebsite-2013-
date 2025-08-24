using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Studio.Entities;

internal class AssetSearchKeywordStatistic : IRobloxEntity<long, AssetSearchKeywordStatisticDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private AssetSearchKeywordStatisticDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(AssetSearchKeywordStatistic).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

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

	internal string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			_EntityDAL.Value = value;
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

	public AssetSearchKeywordStatistic()
	{
		_EntityDAL = new AssetSearchKeywordStatisticDAL();
	}

	public AssetSearchKeywordStatistic(AssetSearchKeywordStatisticDAL entityDAL)
	{
		_EntityDAL = new AssetSearchKeywordStatisticDAL();
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

	internal static AssetSearchKeywordStatistic Get(long id)
	{
		return EntityHelper.GetEntity<long, AssetSearchKeywordStatisticDAL, AssetSearchKeywordStatistic>(EntityCacheInfo, id, () => AssetSearchKeywordStatisticDAL.Get(id));
	}

	internal static ICollection<AssetSearchKeywordStatistic> GetAssetSearchKeywordStatistics(long exclusiveStartId, int count)
	{
		string collectionId = $"GetAssetSearchKeywordStatisticsIDs:{exclusiveStartId}Count:{count}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => AssetSearchKeywordStatisticDAL.GetAssetSearchKeywordStatisticIDs(exclusiveStartId, count), MultiGet);
	}

	private static ICollection<AssetSearchKeywordStatistic> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AssetSearchKeywordStatisticDAL, AssetSearchKeywordStatistic>(ids, EntityCacheInfo, AssetSearchKeywordStatisticDAL.MultiGet);
	}

	public static AssetSearchKeywordStatistic GetByAssetID(long assetId)
	{
		return EntityHelper.GetEntityByLookup<long, AssetSearchKeywordStatisticDAL, AssetSearchKeywordStatistic>(EntityCacheInfo, GetLookupCacheKeysByAssetID(assetId), () => AssetSearchKeywordStatisticDAL.GetAssetSearchKeywordStatisticByAssetID(assetId));
	}

	public void Construct(AssetSearchKeywordStatisticDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByAssetID(AssetID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByAssetID(AssetID));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByAssetID(long assetId)
	{
		return $"AssetID:{assetId}";
	}
}
