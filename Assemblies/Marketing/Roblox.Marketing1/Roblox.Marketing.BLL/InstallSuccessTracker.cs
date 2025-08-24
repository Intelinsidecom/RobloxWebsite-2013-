using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Marketing.DAL;

namespace Roblox.Marketing.BLL;

public class InstallSuccessTracker : IRobloxEntity<long, InstallSuccessTrackerDAL>, ICacheableObject<long>, ICacheableObject
{
	private InstallSuccessTrackerDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.InstallSuccessTracker", isNullCacheable: true);

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

	public InstallSuccessTracker()
	{
		_EntityDAL = new InstallSuccessTrackerDAL();
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

	public static InstallSuccessTracker CreateNew(int? accountid, long browsertrackerid)
	{
		InstallSuccessTracker installSuccessTracker = new InstallSuccessTracker();
		installSuccessTracker.AccountID = accountid;
		installSuccessTracker.BrowserTrackerID = browsertrackerid;
		installSuccessTracker.Save();
		return installSuccessTracker;
	}

	public static InstallSuccessTracker Get(long id)
	{
		throw new NotImplementedException();
	}

	public static ICollection<InstallSuccessTracker> GetInstallSuccessTrackersByBrowserTrackerID(long BrowserTrackerID)
	{
		throw new NotImplementedException();
	}

	public void Construct(InstallSuccessTrackerDAL dal)
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
