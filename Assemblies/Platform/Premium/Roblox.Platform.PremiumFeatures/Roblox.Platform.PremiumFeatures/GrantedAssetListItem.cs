using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class GrantedAssetListItem : IRobloxEntity<long, GrantedAssetListItemDAL>, ICacheableObject<long>, ICacheableObject
{
	private GrantedAssetListItemDAL _EntityDAL;

	internal static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "GrantedAssetListItem", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public int GrantedAssetListID
	{
		get
		{
			return _EntityDAL.GrantedAssetListID;
		}
		set
		{
			_EntityDAL.GrantedAssetListID = value;
		}
	}

	public long AssetID
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

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public GrantedAssetListItem()
	{
		_EntityDAL = new GrantedAssetListItemDAL();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	internal static GrantedAssetListItem Get(long id)
	{
		return EntityHelper.GetEntity<long, GrantedAssetListItemDAL, GrantedAssetListItem>(EntityCacheInfo, id, () => GrantedAssetListItemDAL.Get(id));
	}

	internal static GrantedAssetListItem Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static GrantedAssetListItem GetByGrantedAssetListIDAndAssetID(int grantedAssetListId, long assetId)
	{
		return EntityHelper.GetEntityByLookup<long, GrantedAssetListItemDAL, GrantedAssetListItem>(EntityCacheInfo, $"GrantedAssetListID:{grantedAssetListId}_AssetID:{assetId}", () => GrantedAssetListItemDAL.GetByGrantedAssetListIDAndAssetID(grantedAssetListId, assetId));
	}

	public static ICollection<GrantedAssetListItem> GetGrantedAssetListItemsByGrantedAssetListID(int grantedAssetListId)
	{
		string collectionId = $"GetGrantedAssetListItemsByGrantedAssetListID_GrantedAssetListID:{grantedAssetListId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"GrantedAssetListID:{grantedAssetListId}"), collectionId, () => GrantedAssetListItemDAL.GetGrantedAssetListItemIDsByGrantedAssetListID(grantedAssetListId), Get);
	}

	public void Construct(GrantedAssetListItemDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"GrantedAssetListID:{GrantedAssetListID}_AssetID:{AssetID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"GrantedAssetListID:{GrantedAssetListID}");
	}
}
