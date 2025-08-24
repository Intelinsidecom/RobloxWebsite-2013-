using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class PremiumFeatureActivationTask : IRobloxEntity<long, PremiumFeatureActivationTaskDAL>, ICacheableObject<long>, ICacheableObject, IParallelWorkTask
{
	public delegate void GrantedItemListActivationEventHandler(long premiumFeatureActivationTaskId, EventArgs e);

	public delegate void BuildersClubActivationEventHandler(long accountId, EventArgs e);

	private PremiumFeatureActivationTaskDAL _EntityDAL;

	internal static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "PremiumFeatureActivationTask", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long AccountID
	{
		get
		{
			return _EntityDAL.AccountID;
		}
		set
		{
			_EntityDAL.AccountID = value;
		}
	}

	public int PremiumFeatureID
	{
		get
		{
			return _EntityDAL.PremiumFeatureID;
		}
		set
		{
			_EntityDAL.PremiumFeatureID = value;
		}
	}

	public Guid? WorkerID
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

	public DateTime? Completed
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

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public string UniqueId => ID.ToString();

	public static event GrantedItemListActivationEventHandler GrantedItemListActivation;

	public static event BuildersClubActivationEventHandler BuildersClubActivation;

	public PremiumFeatureActivationTask()
	{
		_EntityDAL = new PremiumFeatureActivationTaskDAL();
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

	public static PremiumFeatureActivationTask CreateNew(long accountId, PremiumFeature premiumFeature)
	{
		PremiumFeatureActivationTask premiumFeatureActivationTask = new PremiumFeatureActivationTask();
		premiumFeatureActivationTask.AccountID = accountId;
		premiumFeatureActivationTask.PremiumFeatureID = premiumFeature.ID;
		premiumFeatureActivationTask.Save();
		return premiumFeatureActivationTask;
	}

	public static PremiumFeatureActivationTask Get(long id)
	{
		return EntityHelper.GetEntity<long, PremiumFeatureActivationTaskDAL, PremiumFeatureActivationTask>(EntityCacheInfo, id, () => PremiumFeatureActivationTaskDAL.Get(id));
	}

	public static ICollection<IParallelWorkTask> LeaseTasks(Guid workerId, int leaseDurationInMinutes, int maxCount)
	{
		List<IParallelWorkTask> entities = new List<IParallelWorkTask>();
		foreach (long item in PremiumFeatureActivationTaskDAL.LeaseTasks(workerId, leaseDurationInMinutes, maxCount))
		{
			PremiumFeatureActivationTaskDAL entityDal = PremiumFeatureActivationTaskDAL.Get(item);
			if (entityDal != null)
			{
				PremiumFeatureActivationTask entity = new PremiumFeatureActivationTask();
				entity.Construct(entityDal);
				CacheManager.ProcessEntityChange(entity, StateChangeEventType.Modification);
				entities.Add(entity);
			}
		}
		return entities;
	}

	public void Construct(PremiumFeatureActivationTaskDAL dal)
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
		PremiumFeature premiumFeature = PremiumFeature.Get(PremiumFeatureID);
		if (premiumFeature.DurationTypeID != DurationType.NoneID)
		{
			AccountAddOnActivationTask.GetOrCreate(ID);
		}
		if (premiumFeature.AdvertisingSuppressionTypeID != AdvertisingSuppressionType.NoneID || premiumFeature.ContentPrivilegeTypeID != ContentPrivilegeType.NoneID || premiumFeature.ShowcaseAllotmentTypeID != ShowcaseAllotmentType.NoneID)
		{
			AccountFeatureSetActivationTask.GetOrCreate(ID);
		}
		if (premiumFeature.GrantedAssetListID != GrantedAssetList.NoneID)
		{
			GrantedAssetListActivationTask.GetOrCreate(ID);
		}
		if (premiumFeature.GrantedBadgeListID != GrantedBadgeList.NoneID)
		{
			GrantedBadgeListActivationTask.GetOrCreate(ID);
		}
		if (premiumFeature.RobuxCreditQuantityTypeID != RobuxCreditQuantityType.NoneID)
		{
			RobuxCreditActivationTask.GetOrCreate(ID);
		}
		if (premiumFeature.GrantedItemListID.HasValue)
		{
			OnGrantedItemListActivation(ID, EventArgs.Empty);
		}
		if (premiumFeature.IsAnyBuildersClub)
		{
			OnBuildersClubActivation(AccountID, EventArgs.Empty);
		}
		WorkerID = PremiumFeatureHelper.WorkerID;
		Completed = DateTime.Now;
		Save();
	}

	protected static void OnBuildersClubActivation(long accountId, EventArgs e)
	{
		if (PremiumFeatureActivationTask.BuildersClubActivation != null)
		{
			PremiumFeatureActivationTask.BuildersClubActivation(accountId, e);
		}
	}

	private static void OnGrantedItemListActivation(long premiumFeatureActivationTaskId, EventArgs e)
	{
		PremiumFeatureActivationTask.GrantedItemListActivation?.Invoke(premiumFeatureActivationTaskId, e);
	}
}
