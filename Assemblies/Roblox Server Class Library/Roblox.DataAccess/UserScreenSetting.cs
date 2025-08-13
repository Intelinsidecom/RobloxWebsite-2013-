using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.DataAccess;

public class UserScreenSetting : IRobloxEntity<long, UserScreenSettingDAL>, ICacheableObject<long>, ICacheableObject
{
	private UserScreenSettingDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.DataAccess.UserScreenSetting", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long UserID
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

	public int RobloxScreenID
	{
		get
		{
			return _EntityDAL.RobloxScreenID;
		}
		set
		{
			_EntityDAL.RobloxScreenID = value;
		}
	}

	public bool IsSuppressed
	{
		get
		{
			return _EntityDAL.IsSuppressed;
		}
		set
		{
			_EntityDAL.IsSuppressed = value;
		}
	}

	public string Parameter
	{
		get
		{
			return _EntityDAL.Parameter;
		}
		set
		{
			_EntityDAL.Parameter = value;
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

	public UserScreenSetting()
	{
		_EntityDAL = new UserScreenSettingDAL();
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

	public static UserScreenSetting CreateNew(long userid, int robloxscreenid, bool issuppressed, string parameter)
	{
		UserScreenSetting userScreenSetting = new UserScreenSetting();
		userScreenSetting.UserID = userid;
		userScreenSetting.RobloxScreenID = robloxscreenid;
		userScreenSetting.IsSuppressed = issuppressed;
		userScreenSetting.Parameter = parameter;
		userScreenSetting.Save();
		return userScreenSetting;
	}

	public static UserScreenSetting Get(long id)
	{
		return EntityHelper.GetEntity<long, UserScreenSettingDAL, UserScreenSetting>(EntityCacheInfo, id, () => UserScreenSettingDAL.Get(id));
	}

	public static UserScreenSetting GetUserScreenSettingByUserIdRobloxScreenIdAndParameter(long userId, int robloxScreenId, string parameter)
	{
		return EntityHelper.GetEntityByLookup<long, UserScreenSettingDAL, UserScreenSetting>(EntityCacheInfo, $"UserID:{userId}_RobloxScreenID:{robloxScreenId}_Parameter:{parameter}", () => UserScreenSettingDAL.GetUserScreenSettingByUserIdRobloxScreenIdAndParameter(userId, robloxScreenId, parameter));
	}

	public void Construct(UserScreenSettingDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"UserID:{UserID}_RobloxScreenID:{RobloxScreenID}_Parameter:{Parameter}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
