using System;
using System.Collections.Generic;
using System.ComponentModel;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;

namespace Roblox;

[Serializable]
public class UserFeed : IEquatable<UserFeed>, IRobloxEntity<long, UserFeedDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private UserFeedDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "UserFeedV2", isNullCacheable: true);

	[DataObjectField(true, true)]
	public long ID => _EntityDAL.ID;

	[DataObjectField(false)]
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

	[DataObjectField(false, false, false)]
	public long FeedID
	{
		get
		{
			return _EntityDAL.FeedID;
		}
		set
		{
			_EntityDAL.FeedID = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public UserFeed()
	{
		_EntityDAL = new UserFeedDAL();
	}

	public UserFeed(UserFeedDAL dal)
	{
		_EntityDAL = dal;
	}

	internal void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	internal static UserFeed CreateNew(long userID, long feedID)
	{
		UserFeed userFeed = new UserFeed();
		userFeed.UserID = userID;
		userFeed.FeedID = feedID;
		userFeed.Save();
		return userFeed;
	}

	public static UserFeed Get(long id)
	{
		return EntityHelper.GetEntity<long, UserFeedDAL, UserFeed>(EntityCacheInfo, id, () => UserFeedDAL.Get(id));
	}

	/// <summary>
	/// Checks existence of a specific item, looked up by UserID and FeedID
	/// </summary>
	internal static bool Exists(long userID, long feedID)
	{
		return EntityHelper.GetEntityByLookup<long, UserFeedDAL, UserFeed>(EntityCacheInfo, $"UserID:{userID}_FeedID:{feedID}", () => UserFeedDAL.GetUserFeedByFeedIDAndUserID(feedID, userID)) != null;
	}

	internal static ICollection<UserFeed> GetUserFeedsByUserIDPaged(long userID, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetUserFeedsByUserID_UserID:{userID}_StartIndex:{startRowIndex}_MaxRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userID}"), collectionId, () => UserFeedDAL.GetUserFeedIDsByUserIDPaged(userID, startRowIndex + 1, maximumRows), Get);
	}

	internal static ICollection<UserFeed> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, UserFeedDAL, UserFeed>(ids, EntityCacheInfo, UserFeedDAL.MultiGet);
	}

	public void Construct(UserFeedDAL dal)
	{
		_EntityDAL = dal;
	}

	public bool Equals(UserFeed other)
	{
		return ID == other?.ID;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"UserID:{UserID}_FeedID:{FeedID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"UserID:{UserID}");
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
