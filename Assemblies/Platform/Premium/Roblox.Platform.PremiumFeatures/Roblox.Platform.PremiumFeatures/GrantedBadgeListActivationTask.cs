using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class GrantedBadgeListActivationTask : IRobloxEntity<long, GrantedBadgeListActivationTaskDAL>, ICacheableObject<long>, ICacheableObject, IParallelWorkTask
{
	private GrantedBadgeListActivationTaskDAL _EntityDAL;

	internal static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "GrantedBadgeListActivationTask", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long PremiumFeatureActivationTaskID
	{
		get
		{
			return _EntityDAL.PremiumFeatureActivationTaskID;
		}
		set
		{
			_EntityDAL.PremiumFeatureActivationTaskID = value;
		}
	}

	internal Guid? WorkerID
	{
		get
		{
			return _EntityDAL.WorkerID;
		}
		set
		{
			_EntityDAL.WorkerID = value;
		}
	}

	internal DateTime? Completed
	{
		get
		{
			return _EntityDAL.Completed;
		}
		set
		{
			_EntityDAL.Completed = value;
		}
	}

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public string UniqueId => ID.ToString();

	public GrantedBadgeListActivationTask()
	{
		_EntityDAL = new GrantedBadgeListActivationTaskDAL();
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

	internal static GrantedBadgeListActivationTask CreateNew(PremiumFeatureActivationTask premiumFeatureActivationTask)
	{
		GrantedBadgeListActivationTask grantedBadgeListActivationTask = new GrantedBadgeListActivationTask();
		grantedBadgeListActivationTask.PremiumFeatureActivationTaskID = premiumFeatureActivationTask.ID;
		grantedBadgeListActivationTask.Save();
		return grantedBadgeListActivationTask;
	}

	internal static GrantedBadgeListActivationTask Get(long id)
	{
		return EntityHelper.GetEntity<long, GrantedBadgeListActivationTaskDAL, GrantedBadgeListActivationTask>(EntityCacheInfo, id, () => GrantedBadgeListActivationTaskDAL.Get(id));
	}

	public static GrantedBadgeListActivationTask GetOrCreate(long premiumFeatureActivationTaskID)
	{
		return EntityHelper.GetOrCreateEntity<long, GrantedBadgeListActivationTask>(EntityCacheInfo, $"PremiumFeatureActivationTaskID:{premiumFeatureActivationTaskID}", () => DoGetOrCreate(premiumFeatureActivationTaskID));
	}

	private static GrantedBadgeListActivationTask DoGetOrCreate(long premiumFeatureActivationTaskID)
	{
		return EntityHelper.DoGetOrCreate<long, GrantedBadgeListActivationTaskDAL, GrantedBadgeListActivationTask>(() => GrantedBadgeListActivationTaskDAL.GetOrCreate(premiumFeatureActivationTaskID));
	}

	public static ICollection<IParallelWorkTask> LeaseTasks(Guid workerId, int leaseDurationInMinutes, int maxCount)
	{
		List<IParallelWorkTask> entities = new List<IParallelWorkTask>();
		foreach (long item in GrantedBadgeListActivationTaskDAL.LeaseTasks(workerId, leaseDurationInMinutes, maxCount))
		{
			GrantedBadgeListActivationTaskDAL entityDal = GrantedBadgeListActivationTaskDAL.Get(item);
			if (entityDal != null)
			{
				GrantedBadgeListActivationTask entity = new GrantedBadgeListActivationTask();
				entity.Construct(entityDal);
				CacheManager.ProcessEntityChange(entity, StateChangeEventType.Modification);
				entities.Add(entity);
			}
		}
		return entities;
	}

	public void Construct(GrantedBadgeListActivationTaskDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public void ProcessTaskAndMarkComplete()
	{
		PremiumFeatureActivationTask premiumFeatureActivationTask = PremiumFeatureActivationTask.Get(PremiumFeatureActivationTaskID);
		PremiumFeature premiumFeature = PremiumFeature.Get(premiumFeatureActivationTask.PremiumFeatureID);
		if (GrantedBadgeList.Get(premiumFeature.GrantedBadgeListID).ID == GrantedBadgeList.NoneID)
		{
			return;
		}
		User user = User.GetByAccountID(premiumFeatureActivationTask.AccountID);
		foreach (GrantedBadgeListItem item in GrantedBadgeListItem.GetGrantedBadgeListItemsByGrantedBadgeListID(premiumFeature.GrantedBadgeListID))
		{
			BadgeType badgeType = BadgeType.Get(item.BadgeTypeID);
			if (badgeType != null)
			{
				if (badgeType.IsAnyBuildersClub)
				{
					Badge.AwardBuildersClubBadge(badgeType, user);
				}
				else
				{
					Badge.CreateNew(badgeType, user);
				}
			}
		}
		if (!user.Badges.Any((Badge badge) => badge.BadgeTypeID == BadgeType.WelcomeToTheClubID))
		{
			Badge.CreateNew(BadgeType.WelcomeToTheClubID, user.ID);
		}
		WorkerID = PremiumFeatureHelper.WorkerID;
		Completed = DateTime.Now;
		Save();
	}
}
