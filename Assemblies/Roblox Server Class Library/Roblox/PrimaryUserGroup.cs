using System;
using System.Linq;
using Roblox.Caching.Shared;
using Roblox.Locking;

namespace Roblox;

/// <summary>
/// This is a special one-off class to back primary groups by shared cache
/// </summary>
public class PrimaryUserGroup
{
	private static readonly ISharedCacheClient _SharedCache = SharedCacheWebClient.GetSingleton();

	private static readonly TimeSpan _SharedCacheExpiry = TimeSpan.FromDays(1.0);

	public static UserGroup GetByUserID(long userId)
	{
		string key = GenerateSharedCacheKey(userId);
		if (_SharedCache.Query(key, out var cachedPrimaryUserGroupId))
		{
			if (cachedPrimaryUserGroupId == null)
			{
				return null;
			}
			UserGroup cachedPrimaryGroup = UserGroup.GetUserGroupsByUserID(userId).FirstOrDefault();
			if (cachedPrimaryGroup != null && cachedPrimaryGroup.IsTopGroup)
			{
				return cachedPrimaryGroup;
			}
		}
		UserGroup primaryGroup = UserGroup.GetTopUserGroupsByUserIDPaged(userId, 0, 1).FirstOrDefault();
		if (primaryGroup != null)
		{
			_SharedCache.Set(key, primaryGroup.ID.ToString(), _SharedCacheExpiry);
			return primaryGroup;
		}
		_SharedCache.SetNull(key, _SharedCacheExpiry);
		return null;
	}

	public static void SetForUserIDAndGroupID(long userId, long groupId)
	{
		LeasedLock leasedLock = LeasedLock.GetOrCreate("Set Primary Group, User: " + userId);
		if (leasedLock.TryAcquire(ParallelTaskWorker.ID, 5000))
		{
			UserGroup oldTopGroup = GetByUserID(userId);
			if (oldTopGroup != null)
			{
				oldTopGroup.IsTopGroup = false;
				oldTopGroup.Save();
			}
			UserGroup newTopGroup = UserGroup.Get(userId, groupId);
			newTopGroup.IsTopGroup = true;
			newTopGroup.Save();
			string key = GenerateSharedCacheKey(userId);
			_SharedCache.Set(key, newTopGroup.ID.ToString(), _SharedCacheExpiry);
			leasedLock.TryRelease(ParallelTaskWorker.ID);
		}
	}

	public static void RemoveForUserID(long userId)
	{
		UserGroup topGroup = GetByUserID(userId);
		if (topGroup != null)
		{
			topGroup.IsTopGroup = false;
			topGroup.Save();
		}
		string key = GenerateSharedCacheKey(userId);
		_SharedCache.Remove(key);
	}

	private static string GenerateSharedCacheKey(long userId)
	{
		return $"PrimaryUserGroupID_UserID:{userId}";
	}
}
