using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Platform.Social.Follow;

namespace Roblox;

[ExcludeFromCodeCoverage]
internal class UserFollowPrivacySetting : IRobloxEntity<long, UserFollowPrivacySettingDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private static readonly HashSet<FollowPrivacyType> _FollowPrivacyTypeList;

	private UserFollowPrivacySettingDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo;

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

	public FollowPrivacyType FollowPrivacyTypeID
	{
		get
		{
			return (FollowPrivacyType)_EntityDAL.FollowPrivacyTypeID;
		}
		set
		{
			if (_FollowPrivacyTypeList.Contains(value))
			{
				_EntityDAL.FollowPrivacyTypeID = (byte)value;
			}
			else
			{
				_EntityDAL.FollowPrivacyTypeID = 0;
			}
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

	static UserFollowPrivacySetting()
	{
		_FollowPrivacyTypeList = new HashSet<FollowPrivacyType>();
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "Roblox.UserFollowPrivacySetting", isNullCacheable: true);
		foreach (object enumVal in Enum.GetValues(typeof(FollowPrivacyType)))
		{
			_FollowPrivacyTypeList.Add((FollowPrivacyType)enumVal);
		}
	}

	public UserFollowPrivacySetting()
	{
		_EntityDAL = new UserFollowPrivacySettingDAL();
	}

	public UserFollowPrivacySetting(UserFollowPrivacySettingDAL dal)
	{
		_EntityDAL = dal;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static UserFollowPrivacySetting DoGetOrCreate(long userId, byte defaultPrivacyTypeId)
	{
		return EntityHelper.DoGetOrCreate<long, UserFollowPrivacySettingDAL, UserFollowPrivacySetting>(() => UserFollowPrivacySettingDAL.GetOrCreate(userId, defaultPrivacyTypeId));
	}

	public static UserFollowPrivacySetting GetOrCreate(long userId, byte defaultPrivacyTypeId)
	{
		UserFollowPrivacySetting userFollowPrivacySetting = EntityHelper.GetOrCreateEntityWithRemoteCache<long, UserFollowPrivacySetting>(EntityCacheInfo, $"UserID:{userId}", () => DoGetOrCreate(userId, defaultPrivacyTypeId), Get);
		if (userFollowPrivacySetting.FollowPrivacyTypeID == FollowPrivacyType.TopFriends)
		{
			userFollowPrivacySetting.FollowPrivacyTypeID = FollowPrivacyType.Friends;
			userFollowPrivacySetting.Save();
		}
		return userFollowPrivacySetting;
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

	public static UserFollowPrivacySetting Get(long id)
	{
		return EntityHelper.GetEntity<long, UserFollowPrivacySettingDAL, UserFollowPrivacySetting>(EntityCacheInfo, id, () => UserFollowPrivacySettingDAL.Get(id));
	}

	public void Construct(UserFollowPrivacySettingDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"UserID:{UserID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
