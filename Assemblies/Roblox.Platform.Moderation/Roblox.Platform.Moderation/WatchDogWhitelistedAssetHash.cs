using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Moderation;

public class WatchDogWhitelistedAssetHash : IRobloxEntity<long, WatchDogWhitelistedAssetHashDAL>, ICacheableObject<long>, ICacheableObject
{
	private WatchDogWhitelistedAssetHashDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(WatchDogWhitelistedAssetHash).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long AssetHashID
	{
		get
		{
			return _EntityDAL.AssetHashID;
		}
		set
		{
			_EntityDAL.AssetHashID = value;
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

	public WatchDogWhitelistedAssetHash()
	{
		_EntityDAL = new WatchDogWhitelistedAssetHashDAL();
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

	public static WatchDogWhitelistedAssetHash CreateNew(long assethashid)
	{
		WatchDogWhitelistedAssetHash watchDogWhitelistedAssetHash = new WatchDogWhitelistedAssetHash();
		watchDogWhitelistedAssetHash.AssetHashID = assethashid;
		watchDogWhitelistedAssetHash.Save();
		return watchDogWhitelistedAssetHash;
	}

	internal static WatchDogWhitelistedAssetHash Get(long id)
	{
		return EntityHelper.GetEntity<long, WatchDogWhitelistedAssetHashDAL, WatchDogWhitelistedAssetHash>(EntityCacheInfo, id, () => WatchDogWhitelistedAssetHashDAL.Get(id));
	}

	public static WatchDogWhitelistedAssetHash GetByAssetHashID(long assetHashID)
	{
		return EntityHelper.GetEntityByLookup<long, WatchDogWhitelistedAssetHashDAL, WatchDogWhitelistedAssetHash>(EntityCacheInfo, $"AssetHashID:{assetHashID}", () => WatchDogWhitelistedAssetHashDAL.GetWatchDogWhitelistedAssetHashByAssetHashID(assetHashID));
	}

	public void Construct(WatchDogWhitelistedAssetHashDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"AssetHashID:{AssetHashID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
