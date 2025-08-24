using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Economy.Business_Logic;

namespace Roblox.Economy;

public class UserLoginAward : IRobloxEntity<int, UserLoginAwardDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private UserLoginAwardDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "UserLoginAward", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

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

	public DateTime? LastAwarded
	{
		get
		{
			return _EntityDAL.LastAwarded;
		}
		set
		{
			_EntityDAL.LastAwarded = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public UserLoginAward()
	{
		_EntityDAL = new UserLoginAwardDAL();
	}

	public UserLoginAward(UserLoginAwardDAL dal)
	{
		_EntityDAL = dal;
	}

	private static UserLoginAward DoGetOrCreate(long userId)
	{
		return EntityHelper.DoGetOrCreate<int, UserLoginAwardDAL, UserLoginAward>(() => UserLoginAwardDAL.GetOrCreate(userId));
	}

	public static UserLoginAward Get(int id)
	{
		return EntityHelper.GetEntity<int, UserLoginAwardDAL, UserLoginAward>(EntityCacheInfo, id, () => UserLoginAwardDAL.Get(id));
	}

	public static UserLoginAward GetOrCreate(long userId)
	{
		return EntityHelper.GetOrCreateEntityWithRemoteCache<int, UserLoginAward>(EntityCacheInfo, $"UserID:{userId}", () => DoGetOrCreate(userId), Get);
	}

	/// <summary>
	/// Checks if the user should receive the login reward, and if so proceeds to reward (and updates records).
	///
	/// NOTE: Currently this method doesn't actually reward anything, because what used to be rewarded is a deprecated feature
	/// and the quantity to reward had been set to 0 since 2016.
	/// </summary>
	public bool TryAward()
	{
		if (LastAwarded.HasValue && LastAwarded.Value > DateTime.Now.AddDays(-1.0) && MarketPlaceSwitches.IsLoginBonusEnabled)
		{
			return false;
		}
		bool num = _EntityDAL.TrySetDailyAward();
		if (num)
		{
			CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
		}
		return num;
	}

	public void Construct(UserLoginAwardDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"UserID:{UserID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
