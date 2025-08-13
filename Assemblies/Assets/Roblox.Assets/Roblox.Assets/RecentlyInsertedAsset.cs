using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Assets;

[Obsolete]
public class RecentlyInsertedAsset : IRobloxEntity<long, RecentlyInsertedAssetDAL>, ICacheableObject<long>, ICacheableObject
{
	public delegate void EntityCreatedEventHandler(RecentlyInsertedAsset sender, EventArgs e);

	public delegate void EntityUpdatedEventHandler(RecentlyInsertedAsset sender, EventArgs e);

	private RecentlyInsertedAssetDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Assets.RecentlyInsertedAsset", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long UserID
	{
		get
		{
			return _EntityDAL.UserID;
		}
		set
		{
			_EntityDAL.UserID = value;
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

	public int AssetTypeID
	{
		get
		{
			return _EntityDAL.AssetTypeID;
		}
		set
		{
			_EntityDAL.AssetTypeID = value;
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

	public static event EntityCreatedEventHandler EntityCreated;

	public static event EntityUpdatedEventHandler EntityUpdated;

	public RecentlyInsertedAsset()
	{
		_EntityDAL = new RecentlyInsertedAssetDAL();
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
			OnEntityCreated(this, EventArgs.Empty);
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
			OnEntityUpdated(this, EventArgs.Empty);
		});
	}

	public static RecentlyInsertedAsset CreateNew(long userId, long assetId, int assetTypeId)
	{
		RecentlyInsertedAsset recentlyInsertedAsset = new RecentlyInsertedAsset();
		recentlyInsertedAsset.UserID = userId;
		recentlyInsertedAsset.AssetID = assetId;
		recentlyInsertedAsset.AssetTypeID = assetTypeId;
		recentlyInsertedAsset.Save();
		return recentlyInsertedAsset;
	}

	public static RecentlyInsertedAsset Get(long id)
	{
		return EntityHelper.GetEntity<long, RecentlyInsertedAssetDAL, RecentlyInsertedAsset>(EntityCacheInfo, id, () => RecentlyInsertedAssetDAL.Get(id));
	}

	public static RecentlyInsertedAsset GetByUserIDAndAssetID(long userID, long assetID)
	{
		return EntityHelper.GetEntityByLookup<long, RecentlyInsertedAssetDAL, RecentlyInsertedAsset>(EntityCacheInfo, $"UserID:{userID}AssetID:{assetID}", () => RecentlyInsertedAssetDAL.GetRecentlyInsertedAssetIDsByUserIDAndAssetID(userID, assetID));
	}

	public static ICollection<RecentlyInsertedAsset> GetByUserIDAndAssetTypeIDPaged(long userID, int assetTypeID, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetRecentlyInsertedAssetsByUserIDAndAssetTypeIDPaged_UserID:{userID}_AssetTypeID:{assetTypeID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userID}AssetTypeID:{assetTypeID}"), collectionId, () => RecentlyInsertedAssetDAL.GetRecentlyInsertedAssetIDsByUserIDAndAssetTypeID_Paged(userID, assetTypeID, startRowIndex + 1, maximumRows), Get);
	}

	private static void OnEntityCreated(RecentlyInsertedAsset entity, EventArgs e)
	{
		if (RecentlyInsertedAsset.EntityCreated != null)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				RecentlyInsertedAsset.EntityCreated(entity, e);
			});
		}
	}

	private static void OnEntityUpdated(RecentlyInsertedAsset entity, EventArgs e)
	{
		if (RecentlyInsertedAsset.EntityUpdated != null)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				RecentlyInsertedAsset.EntityUpdated(entity, e);
			});
		}
	}

	public void Construct(RecentlyInsertedAssetDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"UserID:{UserID}AssetID:{AssetID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"UserID:{UserID}AssetTypeID:{AssetTypeID}");
	}
}
