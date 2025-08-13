using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.AssetMedia;

public class AssetMediaItem : IRobloxEntity<long, AssetMediaItemDAL>, ICacheableObject<long>, ICacheableObject
{
	private AssetMediaItemDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(AssetMediaItem).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

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

	public long MediaAssetID
	{
		get
		{
			return _EntityDAL.MediaAssetID;
		}
		set
		{
			_EntityDAL.MediaAssetID = value;
		}
	}

	public long UploaderUserID
	{
		get
		{
			return _EntityDAL.UploaderUserID;
		}
		set
		{
			_EntityDAL.UploaderUserID = value;
		}
	}

	public int SortOrder
	{
		get
		{
			return _EntityDAL.SortOrder;
		}
		set
		{
			_EntityDAL.SortOrder = value;
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

	public AssetMediaItem()
	{
		_EntityDAL = new AssetMediaItemDAL();
	}

	internal void Save()
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

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal static AssetMediaItem CreateNew(long assetId, long mediaAssetId, long uploaderUserId)
	{
		AssetMediaItem assetMediaItem = new AssetMediaItem();
		assetMediaItem.AssetID = assetId;
		assetMediaItem.MediaAssetID = mediaAssetId;
		assetMediaItem.UploaderUserID = uploaderUserId;
		assetMediaItem.SortOrder = 0;
		assetMediaItem.Save();
		return assetMediaItem;
	}

	public static AssetMediaItem Get(long id)
	{
		return EntityHelper.GetEntity<long, AssetMediaItemDAL, AssetMediaItem>(EntityCacheInfo, id, () => AssetMediaItemDAL.Get(id));
	}

	internal static ICollection<AssetMediaItem> GetAssetMediaItemsByAssetID_Paged(long assetId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetAssetMediaItemsByAssetID_Paged_AssetID:{assetId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AssetID:{assetId}"), collectionId, () => AssetMediaItemDAL.GetAssetMediaItemIDsByAssetID_Paged(assetId, startRowIndex + 1, maximumRows), Get);
	}

	internal static long GetTotalNumberOfAssetMediaItemsByAssetID(long assetId)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AssetID:{assetId}"), $"GetTotalNumberOfAssetMediaItemsByAssetID:{assetId}", () => AssetMediaItemDAL.GetTotalNumberOfAssetMediaItemsByAssetID(assetId));
	}

	void IRobloxEntity<long, AssetMediaItemDAL>.Construct(AssetMediaItemDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"AssetID:{AssetID}");
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
