using System;
using System.Collections.Generic;
using System.ComponentModel;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class UserStatus : IRobloxEntity<long, UserStatusDAL>, ICacheableObject<long>, ICacheableObject, IEquatable<UserStatus>, IRemoteCacheableObject
{
	private UserStatusDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "UserStatus", isNullCacheable: true);

	[DataObjectField(true, true)]
	public long ID => _EntityDAL.ID;

	[DataObjectField(false, false, false)]
	internal long UserID
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

	[DataObjectField(false, false, false)]
	internal string Message
	{
		get
		{
			return _EntityDAL.Message;
		}
		set
		{
			_EntityDAL.Message = value;
		}
	}

	[DataObjectField(false, false, false)]
	internal DateTime Created => _EntityDAL.Created;

	[DataObjectField(false, false, false)]
	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public UserStatus()
	{
		_EntityDAL = new UserStatusDAL();
	}

	public UserStatus(UserStatusDAL dal)
	{
		_EntityDAL = dal;
	}

	internal void Save()
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

	private static UserStatus DoGetOrCreate(long userId)
	{
		return EntityHelper.DoGetOrCreate<long, UserStatusDAL, UserStatus>(() => UserStatusDAL.GetOrCreate(userId));
	}

	internal static UserStatus Get(long id)
	{
		return EntityHelper.GetEntity<long, UserStatusDAL, UserStatus>(EntityCacheInfo, id, () => UserStatusDAL.Get(id));
	}

	public static UserStatus Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	internal static UserStatus GetOrCreate(long userId)
	{
		string entityIdLookup = "UserID:" + userId;
		EntityHelper.GetOrCreate<UserStatus> getterOrCreator = () => DoGetOrCreate(userId);
		return EntityHelper.GetOrCreateEntityWithRemoteCache<long, UserStatus>(EntityCacheInfo, entityIdLookup, getterOrCreator, Get);
	}

	public void Construct(UserStatusDAL dal)
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

	public bool Equals(UserStatus other)
	{
		return ID == other?.ID;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
