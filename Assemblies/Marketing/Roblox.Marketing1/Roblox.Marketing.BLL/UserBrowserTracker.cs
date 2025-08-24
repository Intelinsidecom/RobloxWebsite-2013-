using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Marketing.DAL;

namespace Roblox.Marketing.BLL;

public class UserBrowserTracker : IRobloxEntity<int, UserBrowserTrackerDAL>, ICacheableObject<int>, ICacheableObject
{
	private UserBrowserTrackerDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.UserBrowserTracker", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public int? UserID
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

	public long BrowserTrackerID
	{
		get
		{
			return _EntityDAL.BrowserTrackerID;
		}
		set
		{
			_EntityDAL.BrowserTrackerID = value;
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

	public UserBrowserTracker()
	{
		_EntityDAL = new UserBrowserTrackerDAL();
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
			throw new Exception("Update not implemented for User Browser Tracker");
		});
	}

	public static UserBrowserTracker CreateNew(int? userid, long browserTrackerID)
	{
		UserBrowserTracker userBrowserTracker = new UserBrowserTracker();
		userBrowserTracker.UserID = userid;
		userBrowserTracker.BrowserTrackerID = browserTrackerID;
		userBrowserTracker.Save();
		return userBrowserTracker;
	}

	public static UserBrowserTracker Get(int id)
	{
		return EntityHelper.GetEntity<int, UserBrowserTrackerDAL, UserBrowserTracker>(EntityCacheInfo, id, () => UserBrowserTrackerDAL.Get(id));
	}

	public void Construct(UserBrowserTrackerDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
