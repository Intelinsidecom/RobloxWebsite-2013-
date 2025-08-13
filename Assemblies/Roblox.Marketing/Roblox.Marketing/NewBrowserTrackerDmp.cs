using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class NewBrowserTrackerDmp : IRobloxEntity<int, NewBrowserTrackerDmpDAL>, ICacheableObject<int>, ICacheableObject
{
	private NewBrowserTrackerDmpDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Marketing.NewBrowserTrackerDmp", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	private long BrowserTrackerID
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

	private string UserAgent
	{
		get
		{
			return _EntityDAL.UserAgent;
		}
		set
		{
			_EntityDAL.UserAgent = value;
		}
	}

	private string IPAddress
	{
		get
		{
			return _EntityDAL.IPAddress;
		}
		set
		{
			_EntityDAL.IPAddress = value;
		}
	}

	private string RequestedResource
	{
		get
		{
			return _EntityDAL.RequestedResource;
		}
		set
		{
			_EntityDAL.RequestedResource = value;
		}
	}

	private string AdditionalData
	{
		get
		{
			return _EntityDAL.AdditionalData;
		}
		set
		{
			_EntityDAL.AdditionalData = value;
		}
	}

	private long? UserID
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

	private DateTime Created
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

	private NewBrowserTrackerDmp()
	{
		_EntityDAL = new NewBrowserTrackerDmpDAL();
	}

	private void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Insert();
		}, delegate
		{
		});
	}

	public static NewBrowserTrackerDmp CreateNew(long browsertrackerid, string useragent, string ipaddress, long? userid, string requestedResource, string additionalData)
	{
		NewBrowserTrackerDmp newBrowserTrackerDmp = new NewBrowserTrackerDmp();
		newBrowserTrackerDmp.BrowserTrackerID = browsertrackerid;
		newBrowserTrackerDmp.UserAgent = useragent;
		newBrowserTrackerDmp.IPAddress = ipaddress;
		newBrowserTrackerDmp.UserID = userid;
		newBrowserTrackerDmp.RequestedResource = requestedResource;
		newBrowserTrackerDmp.AdditionalData = additionalData;
		newBrowserTrackerDmp.Save();
		return newBrowserTrackerDmp;
	}

	public void Construct(NewBrowserTrackerDmpDAL dal)
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
