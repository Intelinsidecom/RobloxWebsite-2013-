using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Properties;

namespace Roblox.PremiumFeatures;

public class AccountFeatureSetExpirationTask : IRobloxEntity<long, AccountFeatureSetExpirationTaskDAL>, ICacheableObject<long>, ICacheableObject, IParallelWorkTask
{
	private AccountFeatureSetExpirationTaskDAL _EntityDAL;

	internal static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "AccountFeatureSetExpirationTask", isNullCacheable: true);

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

	public AccountFeatureSetExpirationTask()
	{
		_EntityDAL = new AccountFeatureSetExpirationTaskDAL();
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

	internal static AccountFeatureSetExpirationTask CreateNew(AccountAddOn accountAddOn)
	{
		AccountFeatureSetExpirationTask accountFeatureSetExpirationTask = new AccountFeatureSetExpirationTask();
		accountFeatureSetExpirationTask.AccountAddOnID = accountAddOn.ID;
		accountFeatureSetExpirationTask.Save();
		return accountFeatureSetExpirationTask;
	}

	internal static AccountFeatureSetExpirationTask Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountFeatureSetExpirationTaskDAL, AccountFeatureSetExpirationTask>(EntityCacheInfo, id, () => AccountFeatureSetExpirationTaskDAL.Get(id));
	}

	public static ICollection<IParallelWorkTask> LeaseTasks(Guid workerId, int leaseDurationInMinutes, int maxCount)
	{
		List<IParallelWorkTask> entities = new List<IParallelWorkTask>();
		foreach (long item in AccountFeatureSetExpirationTaskDAL.LeaseTasks(workerId, leaseDurationInMinutes, maxCount))
		{
			AccountFeatureSetExpirationTaskDAL entityDal = AccountFeatureSetExpirationTaskDAL.Get(item);
			if (entityDal != null)
			{
				AccountFeatureSetExpirationTask entity = new AccountFeatureSetExpirationTask();
				entity.Construct(entityDal);
				CacheManager.ProcessEntityChange(entity, StateChangeEventType.Modification);
				entities.Add(entity);
			}
		}
		return entities;
	}

	public void Construct(AccountFeatureSetExpirationTaskDAL dal)
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
		bool canCreateContent = false;
		bool canSellContent = false;
		bool suppressAds = false;
		byte showcaseAllotment = (byte)((!Settings.Default.ExpiredBCActiveSlotsEnabled) ? 1 : Settings.Default.ExpiredBCActiveSlots);
		AccountAddOn accountAddOn = AccountAddOn.Get(AccountAddOnID);
		Account.Get(accountAddOn.AccountID);
		AccountFeatureSet accountFeatureSet = AccountFeatureSet.GetOrCreate(accountAddOn.AccountID);
		if (accountFeatureSet.CanCreateContent != canCreateContent || accountFeatureSet.CanSellContent != canSellContent || accountFeatureSet.SuppressAds != suppressAds || accountFeatureSet.ShowcaseAllotment != showcaseAllotment)
		{
			accountFeatureSet.CanCreateContent = canCreateContent;
			accountFeatureSet.CanSellContent = canSellContent;
			accountFeatureSet.SuppressAds = suppressAds;
			accountFeatureSet.ShowcaseAllotment = showcaseAllotment;
			accountFeatureSet.Save();
		}
		WorkerID = PremiumFeatureHelper.WorkerID;
		Completed = DateTime.Now;
		Save();
	}
}
