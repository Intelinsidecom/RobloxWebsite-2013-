using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Marketing.DAL;

namespace Roblox.Marketing.BLL;

public class InstallBeginTracker : IRobloxEntity<long, InstallBeginTrackerDAL>, ICacheableObject<long>, ICacheableObject
{
	private InstallBeginTrackerDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.InstallBeginTracker", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public int? AccountID
	{
		get
		{
			return _EntityDAL.AccountID;
		}
		set
		{
			_EntityDAL.AccountID = value;
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

	public InstallBeginTracker()
	{
		_EntityDAL = new InstallBeginTrackerDAL();
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
			throw new NotImplementedException();
		});
	}

	public static InstallBeginTracker CreateNew(int? accountid, long browsertrackerid)
	{
		InstallBeginTracker installBeginTracker = new InstallBeginTracker();
		installBeginTracker.AccountID = accountid;
		installBeginTracker.BrowserTrackerID = browsertrackerid;
		installBeginTracker.Save();
		return installBeginTracker;
	}

	public static InstallBeginTracker Get(long id)
	{
		throw new NotImplementedException();
	}

	public static ICollection<InstallBeginTracker> GetInstallBeginTrackersByBrowserTrackerID(long BrowserTrackerID)
	{
		throw new NotImplementedException();
	}

	public void Construct(InstallBeginTrackerDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"BrowserTrackerID:{BrowserTrackerID}");
	}
}
