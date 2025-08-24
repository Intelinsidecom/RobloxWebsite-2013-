using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Marketing.DAL;

namespace Roblox.Marketing.BLL;

public class BootstrapperInstallSuccessTracker : IRobloxEntity<long, BootstrapperInstallSuccessTrackerDAL>, ICacheableObject<long>, ICacheableObject
{
	private BootstrapperInstallSuccessTrackerDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.BootstrapperInstallSuccessTracker", isNullCacheable: true);

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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public BootstrapperInstallSuccessTracker()
	{
		_EntityDAL = new BootstrapperInstallSuccessTrackerDAL();
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Insert();
		}, delegate
		{
			throw new NotImplementedException();
		});
	}

	public static BootstrapperInstallSuccessTracker CreateNew(int? accountid, long browsertrackerid)
	{
		BootstrapperInstallSuccessTracker bootstrapperInstallSuccessTracker = new BootstrapperInstallSuccessTracker();
		bootstrapperInstallSuccessTracker.AccountID = accountid;
		bootstrapperInstallSuccessTracker.BrowserTrackerID = browsertrackerid;
		bootstrapperInstallSuccessTracker.Save();
		return bootstrapperInstallSuccessTracker;
	}

	public static BootstrapperInstallSuccessTracker Get(long id)
	{
		throw new NotImplementedException();
	}

	public static ICollection<BootstrapperInstallSuccessTracker> GetBootstrapperInstallSuccessTrackersByBrowserTrackerID(long BrowserTrackerID)
	{
		throw new NotImplementedException();
	}

	public void Construct(BootstrapperInstallSuccessTrackerDAL dal)
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
