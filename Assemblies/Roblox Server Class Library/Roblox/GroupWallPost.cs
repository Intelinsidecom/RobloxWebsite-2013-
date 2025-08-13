using System;
using System.Collections.Generic;
using System.ComponentModel;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataV2.Core;
using Roblox.Properties;
using Roblox.Redis.Lru;
using StackExchange.Redis;

namespace Roblox;

[Serializable]
public class GroupWallPost : IEquatable<GroupWallPost>, IRobloxEntity<long, GroupWallPostDAL>, ICacheableObject<long>, ICacheableObject
{
	private const string _WallPostCountCacheKeyPrefix = "GroupWallPost_CountByGroup_";

	private GroupWallPostDAL _EntityDAL;

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
	public long GroupID
	{
		get
		{
			return _EntityDAL.GroupID;
		}
		set
		{
			_EntityDAL.GroupID = value;
		}
	}

	[DataObjectField(false, false, false)]
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

	[DataObjectField(false)]
	public DateTime Created => _EntityDAL.Created;

	[DataObjectField(false)]
	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static CacheInfo EntityCacheInfo => new CacheInfo("GroupWallPost");

	private GroupWallPost(GroupWallPostDAL dal)
	{
		_EntityDAL = dal;
	}

	public GroupWallPost()
	{
		_EntityDAL = new GroupWallPostDAL();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
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

	internal static GroupWallPost CreateNew(long userID, long groupId, string value)
	{
		string trimVal = value.Trim();
		GroupWallPost groupWallPost = new GroupWallPost();
		groupWallPost.UserID = userID;
		groupWallPost.GroupID = groupId;
		groupWallPost.Value = ((trimVal.Length > 500) ? trimVal.Substring(0, 500) : trimVal);
		groupWallPost.Save();
		return groupWallPost;
	}

	public static GroupWallPost Get(long id)
	{
		return EntityHelper.GetEntity<long, GroupWallPostDAL, GroupWallPost>(EntityCacheInfo, id, () => GroupWallPostDAL.Get(id));
	}

	public static ICollection<GroupWallPost> GetGroupWallPostsByGroupId(long groupId, int count, long? exclusiveStartId, SortOrder sortOrder)
	{
		string collectionId = $"GetGroupWallPostsByGroupID_GroupID:{groupId}_Count:{count}_ExclusiveStartID:{exclusiveStartId}_SortOrder:{sortOrder}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, GetCacheStateQualifierByGroupId(groupId)), collectionId, () => GroupWallPostDAL.GetGroupWallPostIDsByGroupID(groupId, count, exclusiveStartId, sortOrder), Get);
	}

	public static ICollection<GroupWallPost> GetGroupWallPostsByGroupIDPaged(long groupId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetGroupWallPostsByGroupIDPaged_GroupID:{groupId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, GetCacheStateQualifierByGroupId(groupId)), collectionId, () => GroupWallPostDAL.GetGroupWallPostIDsByGroupIDPaged(groupId, startRowIndex + 1, maximumRows), Get);
	}

	public static ICollection<GroupWallPost> GetTopGroupWallPostsByUserIDAndGroupID(long userId, long groupId, int maximumRows)
	{
		string collectionId = $"GetTopGroupWallPostsByUserIDAndGroupID_UserID:{userId}_GroupID:{groupId}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, GetCacheStateQualifierByUserIdAndGroupId(userId, groupId)), collectionId, () => GroupWallPostDAL.GetTopGroupWallPostIDsByUserIDAndGroupID(userId, groupId, maximumRows), Get);
	}

	public static int GetTotalNumberOfGroupWallPostsByGroupID(long groupId)
	{
		bool lruCacheEnabled = Settings.Default.GroupWallPostCountCacheEnabled;
		string lruCacheKey = "GroupWallPost_CountByGroup_" + groupId;
		if (lruCacheEnabled)
		{
			RedisValue lruCount = RedisLruClient.GetInstance().Execute(lruCacheKey, (IDatabase db) => db.StringGet(lruCacheKey));
			if (lruCount.HasValue)
			{
				return (int)lruCount;
			}
		}
		int count = EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, GetCacheStateQualifierByGroupId(groupId)), $"GetTotalNumberOfGroupWallPostsByGroupID_GroupID:{groupId}", () => GroupWallPostDAL.GetTotalNumberOfGroupWallPostsByGroupID(groupId));
		if (lruCacheEnabled && count >= Settings.Default.GroupWallPostCountCacheThreshold)
		{
			RedisLruClient.GetInstance().Execute(lruCacheKey, (IDatabase db) => db.StringSet(lruCacheKey, count, Settings.Default.GroupWallPostCountCacheExpiration, When.Always, CommandFlags.FireAndForget));
		}
		return count;
	}

	public static int GetTotalNumberOfGroupWallPostsByUserID(long userID)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, GetCacheStateQualifierByUserId(userID)), $"GetTotalNumberOfGroupWallPostsByUserID_UserID:{userID}", () => GroupWallPostDAL.GetTotalNumberOfGroupWallPostsByUserID(userID));
	}

	public void Construct(GroupWallPostDAL dal)
	{
		_EntityDAL = dal;
	}

	public bool Equals(GroupWallPost other)
	{
		if (other == null)
		{
			return false;
		}
		return ID == other.ID;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		return new List<StateToken>
		{
			new StateToken(GetCacheStateQualifierByUserId(UserID)),
			new StateToken(GetCacheStateQualifierByGroupId(GroupID)),
			new StateToken(GetCacheStateQualifierByUserIdAndGroupId(UserID, GroupID))
		};
	}

	private static string GetCacheStateQualifierByGroupId(long groupId)
	{
		return $"GroupID:{groupId}";
	}

	private static string GetCacheStateQualifierByUserId(long userId)
	{
		return $"UserID:{userId}";
	}

	private static string GetCacheStateQualifierByUserIdAndGroupId(long userId, long groupId)
	{
		return $"UserID:{userId}_GroupID:{groupId}";
	}
}
