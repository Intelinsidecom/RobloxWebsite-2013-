using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.AssetMedia;

public class PlaceMediaItem : IRobloxEntity<int, PlaceMediaItemDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private PlaceMediaItemDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.AssetMedia.PlaceMediaItem", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public long PlaceID
	{
		get
		{
			return _EntityDAL.PlaceID;
		}
		set
		{
			_EntityDAL.PlaceID = value;
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

	public PlaceMediaItem()
	{
		_EntityDAL = new PlaceMediaItemDAL();
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

	internal static PlaceMediaItem CreateNew(long placeId, long mediaAssetId, long uploaderUserId)
	{
		PlaceMediaItem placeMediaItem = new PlaceMediaItem();
		placeMediaItem.PlaceID = placeId;
		placeMediaItem.MediaAssetID = mediaAssetId;
		placeMediaItem.UploaderUserID = uploaderUserId;
		placeMediaItem.SortOrder = 0;
		placeMediaItem.Save();
		return placeMediaItem;
	}

	public static PlaceMediaItem Get(int id)
	{
		return EntityHelper.GetEntity<int, PlaceMediaItemDAL, PlaceMediaItem>(EntityCacheInfo, id, () => PlaceMediaItemDAL.Get(id));
	}

	/// <summary>
	/// This returns sorted by IsPrimary DESC
	/// </summary>
	internal static ICollection<PlaceMediaItem> GetPlaceMediaItemsByPlaceID_Paged(long placeId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetPlaceMediaItemsByPlaceID_Paged_PlaceID:{placeId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PlaceID:{placeId}"), collectionId, () => PlaceMediaItemDAL.GetPlaceMediaItemIDsByPlaceID_Paged(placeId, startRowIndex + 1, maximumRows), Get);
	}

	internal static int GetTotalNumberOfPlaceMediaItemsByPlaceID(long placeId)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PlaceID:{placeId}"), $"GetTotalNumberOfPlaceMediaItemsByPlaceID:{placeId}", () => PlaceMediaItemDAL.GetTotalNumberOfPlaceMediaItemsByPlaceID(placeId));
	}

	void IRobloxEntity<int, PlaceMediaItemDAL>.Construct(PlaceMediaItemDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"PlaceID:{PlaceID}");
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
