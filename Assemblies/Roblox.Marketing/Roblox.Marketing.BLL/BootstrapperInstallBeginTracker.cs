using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Marketing.DAL;

namespace Roblox.Marketing.BLL;

public class BootstrapperInstallBeginTracker : IRobloxEntity<long, BootstrapperInstallBeginTrackerDAL>, ICacheableObject<long>, ICacheableObject
{
	private BootstrapperInstallBeginTrackerDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.BootstrapperInstallBeginTracker", isNullCacheable: true);

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

	public BootstrapperInstallBeginTracker()
	{
		_EntityDAL = new BootstrapperInstallBeginTrackerDAL();
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

	public static BootstrapperInstallBeginTracker CreateNew(int? accountid, long browsertrackerid)
	{
		BootstrapperInstallBeginTracker bootstrapperInstallBeginTracker = new BootstrapperInstallBeginTracker();
		bootstrapperInstallBeginTracker.AccountID = accountid;
		bootstrapperInstallBeginTracker.BrowserTrackerID = browsertrackerid;
		bootstrapperInstallBeginTracker.Save();
		return bootstrapperInstallBeginTracker;
	}

	public static BootstrapperInstallBeginTracker Get(long id)
	{
		throw new NotImplementedException();
	}

	public static ICollection<BootstrapperInstallBeginTracker> GetBootstrapperInstallBeginTrackersByBrowserTrackerID(long BrowserTrackerID)
	{
		throw new NotImplementedException();
	}

	public void Construct(BootstrapperInstallBeginTrackerDAL dal)
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
