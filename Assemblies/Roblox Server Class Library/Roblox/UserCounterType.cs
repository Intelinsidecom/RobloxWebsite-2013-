using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class UserCounterType : IRobloxEntity<byte, UserCounterTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private UserCounterTypeDAL _EntityDAL;

	public static readonly byte FriendsV2ID;

	public static readonly string FriendsV2Value;

	public static readonly byte FollowerID;

	public static readonly string FollowersValue;

	public static readonly byte FollowingID;

	public static readonly string FollowingsValue;

	public static readonly byte FriendReferralsAllTimeID;

	public static readonly string FriendReferralsAllTimeValue;

	public static readonly byte UnreadMessagesID;

	public static readonly string UnreadMessagesValue;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			_EntityDAL.Value = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public UserCounterType()
	{
		_EntityDAL = new UserCounterTypeDAL();
	}

	static UserCounterType()
	{
		FriendsV2Value = "FriendsV2";
		FollowersValue = "Followers";
		FollowingsValue = "Followings";
		FriendReferralsAllTimeValue = "Friend Referrals All Time";
		UnreadMessagesValue = "Unread Messages";
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "UserCounterType", isNullCacheable: true);
		FriendsV2ID = Get(FriendsV2Value).ID;
		FriendReferralsAllTimeID = Get(FriendReferralsAllTimeValue).ID;
		UnreadMessagesID = Get(UnreadMessagesValue).ID;
		FollowerID = Get(FollowersValue).ID;
		FollowingID = Get(FollowingsValue).ID;
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
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

	public static UserCounterType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, UserCounterTypeDAL, UserCounterType>(EntityCacheInfo, id, () => UserCounterTypeDAL.Get(id));
	}

	public static UserCounterType Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static UserCounterType Get(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, UserCounterTypeDAL, UserCounterType>(EntityCacheInfo, value, () => UserCounterTypeDAL.Get(value));
	}

	public void Construct(UserCounterTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		ICollection<string> idLookups = new List<string>();
		if (_EntityDAL != null)
		{
			idLookups.Add(Value);
		}
		return idLookups;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
