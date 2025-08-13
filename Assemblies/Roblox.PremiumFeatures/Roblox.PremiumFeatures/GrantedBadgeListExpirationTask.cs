using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class GrantedBadgeListExpirationTask : IRobloxEntity<long, GrantedBadgeListExpirationTaskDAL>, ICacheableObject<long>, ICacheableObject, IParallelWorkTask
{
	private GrantedBadgeListExpirationTaskDAL _EntityDAL;

	internal static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "GrantedBadgeListExpirationTask", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal int AccountAddOnID
	{
		get
		{
			return _EntityDAL.AccountAddOnID;
		}
		set
		{
			_EntityDAL.AccountAddOnID = value;
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

	public GrantedBadgeListExpirationTask()
	{
		_EntityDAL = new GrantedBadgeListExpirationTaskDAL();
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

	internal static GrantedBadgeListExpirationTask CreateNew(AccountAddOn accountAddOn)
	{
		GrantedBadgeListExpirationTask grantedBadgeListExpirationTask = new GrantedBadgeListExpirationTask();
		grantedBadgeListExpirationTask.AccountAddOnID = accountAddOn.ID;
		grantedBadgeListExpirationTask.Save();
		return grantedBadgeListExpirationTask;
	}

	internal static GrantedBadgeListExpirationTask Get(long id)
	{
		return EntityHelper.GetEntity<long, GrantedBadgeListExpirationTaskDAL, GrantedBadgeListExpirationTask>(EntityCacheInfo, id, () => GrantedBadgeListExpirationTaskDAL.Get(id));
	}

	public static ICollection<IParallelWorkTask> LeaseTasks(Guid workerId, int leaseDurationInMinutes, int maxCount)
	{
		List<IParallelWorkTask> entities = new List<IParallelWorkTask>();
		foreach (long item in GrantedBadgeListExpirationTaskDAL.LeaseTasks(workerId, leaseDurationInMinutes, maxCount))
		{
			GrantedBadgeListExpirationTaskDAL entityDal = GrantedBadgeListExpirationTaskDAL.Get(item);
			if (entityDal != null)
			{
				GrantedBadgeListExpirationTask entity = new GrantedBadgeListExpirationTask();
				entity.Construct(entityDal);
				CacheManager.ProcessEntityChange(entity, StateChangeEventType.Modification);
				entities.Add(entity);
			}
		}
		return entities;
	}

	public void Construct(GrantedBadgeListExpirationTaskDAL dal)
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
		AccountAddOn accountAddOn = AccountAddOn.Get(AccountAddOnID);
		PremiumFeature premiumFeature = PremiumFeature.Get(accountAddOn.PremiumFeatureID);
		if (GrantedAssetList.Get(premiumFeature.GrantedAssetListID).ID == GrantedAssetList.NoneID)
		{
			return;
		}
		List<Badge> userBadges = Badge.GetUserBadgesByUserID(User.GetByAccountID(accountAddOn.AccountID).ID).ToList();
		foreach (GrantedBadgeListItem grantedBadgeListItem in GrantedBadgeListItem.GetGrantedBadgeListItemsByGrantedBadgeListID(premiumFeature.GrantedBadgeListID))
		{
			BadgeType badgeType = BadgeType.Get(grantedBadgeListItem.BadgeTypeID);
			if (badgeType == null)
			{
				return;
			}
			foreach (Badge item in userBadges.FindAll((Badge badge) => Badge.BadgeExistsPredicate(badge, badgeType)))
			{
				item.Delete();
			}
		}
		WorkerID = PremiumFeatureHelper.WorkerID;
		Completed = DateTime.Now;
		Save();
	}
}
