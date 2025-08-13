using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class AccountFeatureSetActivationTask : IRobloxEntity<long, AccountFeatureSetActivationTaskDAL>, ICacheableObject<long>, ICacheableObject, IParallelWorkTask
{
	private AccountFeatureSetActivationTaskDAL _EntityDAL;

	internal static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "AccountFeatureSetActivationTask", isNullCacheable: true);

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

	public AccountFeatureSetActivationTask()
	{
		_EntityDAL = new AccountFeatureSetActivationTaskDAL();
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

	internal static AccountFeatureSetActivationTask CreateNew(PremiumFeatureActivationTask premiumFeatureActivationTask)
	{
		AccountFeatureSetActivationTask accountFeatureSetActivationTask = new AccountFeatureSetActivationTask();
		accountFeatureSetActivationTask.PremiumFeatureActivationTaskID = premiumFeatureActivationTask.ID;
		accountFeatureSetActivationTask.Save();
		return accountFeatureSetActivationTask;
	}

	internal static AccountFeatureSetActivationTask Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountFeatureSetActivationTaskDAL, AccountFeatureSetActivationTask>(EntityCacheInfo, id, () => AccountFeatureSetActivationTaskDAL.Get(id));
	}

	public static AccountFeatureSetActivationTask GetOrCreate(long premiumFeatureActivationTaskID)
	{
		return EntityHelper.GetOrCreateEntity<long, AccountFeatureSetActivationTask>(EntityCacheInfo, $"PremiumFeatureActivationTaskID:{premiumFeatureActivationTaskID}", () => DoGetOrCreate(premiumFeatureActivationTaskID));
	}

	private static AccountFeatureSetActivationTask DoGetOrCreate(long premiumFeatureActivationTaskID)
	{
		return EntityHelper.DoGetOrCreate<long, AccountFeatureSetActivationTaskDAL, AccountFeatureSetActivationTask>(() => AccountFeatureSetActivationTaskDAL.GetOrCreate(premiumFeatureActivationTaskID));
	}

	public static ICollection<IParallelWorkTask> LeaseTasks(Guid workerId, int leaseDurationInMinutes, int maxCount)
	{
		List<IParallelWorkTask> entities = new List<IParallelWorkTask>();
		foreach (long item in AccountFeatureSetActivationTaskDAL.LeaseTasks(workerId, leaseDurationInMinutes, maxCount))
		{
			AccountFeatureSetActivationTaskDAL entityDal = AccountFeatureSetActivationTaskDAL.Get(item);
			if (entityDal != null)
			{
				AccountFeatureSetActivationTask entity = new AccountFeatureSetActivationTask();
				entity.Construct(entityDal);
				CacheManager.ProcessEntityChange(entity, StateChangeEventType.Modification);
				entities.Add(entity);
			}
		}
		return entities;
	}

	public void Construct(AccountFeatureSetActivationTaskDAL dal)
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
		AccountFeatureSet accountFeatureSet = AccountFeatureSet.GetOrCreate(premiumFeatureActivationTask.AccountID);
		string value = ContentPrivilegeType.Get(premiumFeature.ContentPrivilegeTypeID).Value;
		if (value == "Create and Sell")
		{
			accountFeatureSet.CanCreateContent = true;
			accountFeatureSet.CanSellContent = true;
		}
		value = AdvertisingSuppressionType.Get(premiumFeature.AdvertisingSuppressionTypeID).Value;
		if (value == "External")
		{
			accountFeatureSet.SuppressAds = true;
		}
		ShowcaseAllotmentType showcaseAllotmentType = ShowcaseAllotmentType.Get(premiumFeature.ShowcaseAllotmentTypeID);
		value = showcaseAllotmentType.Value;
		if (!(value == "None") && accountFeatureSet.ShowcaseAllotment != ShowcaseAllotmentType.MaximumNumberOfShowcases)
		{
			accountFeatureSet.ShowcaseAllotment = showcaseAllotmentType.Amount;
		}
		accountFeatureSet.Save();
		WorkerID = PremiumFeatureHelper.WorkerID;
		Completed = DateTime.Now;
		Save();
	}
}
