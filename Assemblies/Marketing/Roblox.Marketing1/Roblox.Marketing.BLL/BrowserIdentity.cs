using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Marketing.DAL;

namespace Roblox.Marketing.BLL;

public class BrowserIdentity : IRobloxEntity<int, BrowserIdentityDAL>, ICacheableObject<int>, ICacheableObject
{
	private BrowserIdentityDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.BrowserIdentity", isNullCacheable: true);

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

	public int? BrowserID
	{
		get
		{
			return _EntityDAL.BrowserID;
		}
		set
		{
			_EntityDAL.BrowserID = value;
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

	public BrowserIdentity()
	{
		_EntityDAL = new BrowserIdentityDAL();
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
			throw new Exception("Update not implemented for Browser identity");
		});
	}

	public static BrowserIdentity CreateNew(int? userid, int? browserid)
	{
		BrowserIdentity browserIdentity = new BrowserIdentity();
		browserIdentity.UserID = userid;
		browserIdentity.BrowserID = browserid;
		browserIdentity.Save();
		return browserIdentity;
	}

	public static BrowserIdentity Get(int id)
	{
		return EntityHelper.GetEntity<int, BrowserIdentityDAL, BrowserIdentity>(EntityCacheInfo, id, () => BrowserIdentityDAL.Get(id));
	}

	public void Construct(BrowserIdentityDAL dal)
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
