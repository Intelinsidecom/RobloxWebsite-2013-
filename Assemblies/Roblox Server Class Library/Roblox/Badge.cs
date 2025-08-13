using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;
using Roblox.Locking;

namespace Roblox;

[Serializable]
public class Badge : IRobloxEntity<int, BadgeDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private BadgeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "Roblox.Badge", isNullCacheable: true);

	public int ID
	{
		get
		{
			return _EntityDAL.ID;
		}
		set
		{
			_EntityDAL.ID = value;
		}
	}

	public int BadgeTypeID
	{
		get
		{
			return _EntityDAL.BadgeTypeID;
		}
		set
		{
			_EntityDAL.BadgeTypeID = value;
		}
	}

	public BadgeType Type
	{
		get
		{
			return BadgeType.Get(_EntityDAL.BadgeTypeID);
		}
		set
		{
			if (value != null)
			{
				_EntityDAL.BadgeTypeID = value.ID;
			}
			else
			{
				_EntityDAL.BadgeTypeID = 0;
			}
		}
	}

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

	public User Recipient
	{
		get
		{
			return User.Get(_EntityDAL.UserID);
		}
		set
		{
			if (value != null)
			{
				_EntityDAL.UserID = value.ID;
			}
			else
			{
				_EntityDAL.UserID = 0L;
			}
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public bool IsAnyBuildersClub
	{
		get
		{
			if (BadgeTypeID != BadgeType.BuildersClubID && BadgeTypeID != BadgeType.TurboBuildersClubID)
			{
				return BadgeTypeID == BadgeType.OutrageousBuildersClubID;
			}
			return true;
		}
	}

	public bool IsNullCacheable => true;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Badge(BadgeDAL dal)
	{
		_EntityDAL = dal;
	}

	public Badge()
	{
		_EntityDAL = new BadgeDAL();
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

	public static void AwardBuildersClubBadge(BadgeType type, User recipient)
	{
		foreach (Badge badge in GetUserBadgesByUserID(recipient.ID))
		{
			if (badge.BadgeTypeID == type.ID)
			{
				return;
			}
			switch (type.Value)
			{
			case "Builders Club":
				if (badge.BadgeTypeID == BadgeType.TurboBuildersClubID || badge.BadgeTypeID == BadgeType.OutrageousBuildersClubID)
				{
					badge.Delete();
				}
				break;
			case "Turbo Builders Club":
				if (badge.BadgeTypeID == BadgeType.BuildersClubID || badge.BadgeTypeID == BadgeType.OutrageousBuildersClubID)
				{
					badge.Delete();
				}
				break;
			case "Outrageous Builders Club":
				if (badge.BadgeTypeID == BadgeType.BuildersClubID || badge.BadgeTypeID == BadgeType.TurboBuildersClubID)
				{
					badge.Delete();
				}
				break;
			}
		}
		CreateNew(type, recipient);
	}

	public static bool BadgeExistsPredicate(Badge badge, BadgeType badgeType)
	{
		if (badge.BadgeTypeID == badgeType.ID)
		{
			return true;
		}
		return false;
	}

	public static Badge CreateNew(int badgeTypeId, long recipientUserId)
	{
		Badge entity = null;
		LeasedLock leasedLock = LeasedLock.GetOrCreate($"UserBadgeCreate_{badgeTypeId}_{recipientUserId}");
		bool isLockAcquired = false;
		try
		{
			isLockAcquired = leasedLock.TryAcquire(ParallelTaskWorker.ID, 20000);
			if (isLockAcquired)
			{
				Badge match = GetUserBadgesByUserID(recipientUserId).FirstOrDefault((Badge badge) => badge.BadgeTypeID == badgeTypeId);
				if (match != null)
				{
					entity = match;
				}
				else
				{
					entity = new Badge
					{
						BadgeTypeID = badgeTypeId,
						UserID = recipientUserId
					};
					entity.Save();
				}
			}
		}
		finally
		{
			if (isLockAcquired)
			{
				leasedLock.TryRelease(ParallelTaskWorker.ID);
			}
		}
		return entity;
	}

	public static Badge CreateNew(BadgeType type, User recipient)
	{
		return CreateNew(type.ID, recipient.ID);
	}

	public static Badge Get(int id)
	{
		return EntityHelper.GetEntity<int, BadgeDAL, Badge>(EntityCacheInfo, id, () => BadgeDAL.Get(id));
	}

	public static ICollection<Badge> GetUserBadgesByUserID(long userId)
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "UserID:" + userId), $"GetUserBadgesByUserID:{userId}", () => BadgeDAL.GetUserBadgeIDsByUserID(userId), Get);
	}

	public static void RevokeBuildersClubBadge(User user)
	{
		foreach (Badge badge in GetUserBadgesByUserID(user.ID))
		{
			if (badge.IsAnyBuildersClub)
			{
				badge.Delete();
			}
		}
	}

	public string GetIdentifier()
	{
		return ID.ToString();
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	public void Construct(BadgeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken("UserID:" + UserID);
	}
}
