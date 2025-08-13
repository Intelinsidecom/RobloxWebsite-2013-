using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.DataAccess;

public class RobloxScreen : IRobloxEntity<int, RobloxScreenDAL>, ICacheableObject<int>, ICacheableObject
{
	private RobloxScreenDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.DataAccess.RobloxScreen", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public string ScreenName
	{
		get
		{
			return _EntityDAL.ScreenName;
		}
		set
		{
			_EntityDAL.ScreenName = value;
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

	public RobloxScreen()
	{
		_EntityDAL = new RobloxScreenDAL();
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
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static RobloxScreen CreateNew(string screenname)
	{
		RobloxScreen robloxScreen = new RobloxScreen();
		robloxScreen.ScreenName = screenname;
		robloxScreen.Save();
		return robloxScreen;
	}

	public static RobloxScreen Get(int id)
	{
		return EntityHelper.GetEntity<int, RobloxScreenDAL, RobloxScreen>(EntityCacheInfo, id, () => RobloxScreenDAL.Get(id));
	}

	public static RobloxScreen Get(string screenName)
	{
		return EntityHelper.GetEntityByLookup<int, RobloxScreenDAL, RobloxScreen>(EntityCacheInfo, string.Format("ScreenName:{0}", screenName.Replace(" ", "_RBXSPC_")), () => RobloxScreenDAL.Get(screenName));
	}

	public void Construct(RobloxScreenDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return string.Format("ScreenName:{0}", ScreenName.Replace(" ", "_RBXSPC_"));
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
