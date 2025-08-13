using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Moderation;

public class WatchDogWhitelistedPlaceCreator : IRobloxEntity<long, WatchDogWhitelistedPlaceCreatorDAL>, ICacheableObject<long>, ICacheableObject
{
	private WatchDogWhitelistedPlaceCreatorDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(WatchDogWhitelistedPlaceCreator).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long CreatorID
	{
		get
		{
			return _EntityDAL.CreatorID;
		}
		set
		{
			_EntityDAL.CreatorID = value;
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

	public WatchDogWhitelistedPlaceCreator()
	{
		_EntityDAL = new WatchDogWhitelistedPlaceCreatorDAL();
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

	internal static WatchDogWhitelistedPlaceCreator CreateNew(long creatorid)
	{
		WatchDogWhitelistedPlaceCreator watchDogWhitelistedPlaceCreator = new WatchDogWhitelistedPlaceCreator();
		watchDogWhitelistedPlaceCreator.CreatorID = creatorid;
		watchDogWhitelistedPlaceCreator.Save();
		return watchDogWhitelistedPlaceCreator;
	}

	internal static WatchDogWhitelistedPlaceCreator Get(long id)
	{
		return EntityHelper.GetEntity<long, WatchDogWhitelistedPlaceCreatorDAL, WatchDogWhitelistedPlaceCreator>(EntityCacheInfo, id, () => WatchDogWhitelistedPlaceCreatorDAL.Get(id));
	}

	public static WatchDogWhitelistedPlaceCreator GetByCreatorID(long creatorID)
	{
		return EntityHelper.GetEntityByLookup<long, WatchDogWhitelistedPlaceCreatorDAL, WatchDogWhitelistedPlaceCreator>(EntityCacheInfo, $"CreatorID:{creatorID}", () => WatchDogWhitelistedPlaceCreatorDAL.GetWatchDogWhitelistedPlaceCreatorByCreatorID(creatorID));
	}

	public void Construct(WatchDogWhitelistedPlaceCreatorDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"CreatorID:{CreatorID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
