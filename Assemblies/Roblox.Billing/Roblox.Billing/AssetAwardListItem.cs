using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class AssetAwardListItem : IRobloxEntity<int, AssetAwardListItemDAL>, ICacheableObject<int>, ICacheableObject
{
	private AssetAwardListItemDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.AssetAwardListItem", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

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

	public int AssetAwardListID
	{
		get
		{
			return _EntityDAL.AssetAwardListID;
		}
		set
		{
			_EntityDAL.AssetAwardListID = value;
		}
	}

	public DateTime Created
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

	public DateTime Updated
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

	public bool IsNullCacheable => true;

	public AssetAwardListItem()
	{
		_EntityDAL = new AssetAwardListItemDAL();
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

	public static AssetAwardListItem CreateNew(long assetid, int assetawardlistid)
	{
		AssetAwardListItem assetAwardListItem = new AssetAwardListItem();
		assetAwardListItem.AssetID = assetid;
		assetAwardListItem.AssetAwardListID = assetawardlistid;
		assetAwardListItem.Save();
		return assetAwardListItem;
	}

	public static AssetAwardListItem Get(int id)
	{
		return EntityHelper.GetEntity<int, AssetAwardListItemDAL, AssetAwardListItem>(EntityCacheInfo, id, () => AssetAwardListItemDAL.Get(id));
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public static ICollection<AssetAwardListItem> GetAssetAwardListItemsByAssetAwardListID(int assetAwardListId)
	{
		string collectionId = $"GetAssetAwardListItemsByAssetAwardListID_AssetAwardListID:{assetAwardListId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AssetAwardListID:{assetAwardListId}"), collectionId, () => AssetAwardListItemDAL.GetAssetAwardListItemIDsByAssetAwardListID(assetAwardListId), Get);
	}

	public void Construct(AssetAwardListItemDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"AssetAwardListID:{AssetAwardListID}");
		yield return new StateToken($"AssetAwardListID:{AssetAwardListID}");
	}

	public string GetIdentifier()
	{
		return ID.ToString();
	}
}
