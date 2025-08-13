using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Economy.Common;

namespace Roblox.PremiumFeatures;

public class RobuxCreditActivationTask : IRobloxEntity<long, RobuxCreditActivationTaskDAL>, ICacheableObject<long>, ICacheableObject, IParallelWorkTask
{
	public delegate void RobuxCreditPayoutHandler(long userId, long balanceBefore, long amount, EventArgs e);

	private const double _ProcessingBufferInSeconds = 10.0;

	private RobuxCreditActivationTaskDAL _EntityDAL;

	internal static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "RobuxCreditActivationTask", isNullCacheable: true);

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

	internal DateTime LatestProcessingTime { get; set; }

	public CacheInfo CacheInfo => EntityCacheInfo;

	public string UniqueId => ID.ToString();

	public static event RobuxCreditPayoutHandler RobuxCreditPayout;

	public RobuxCreditActivationTask()
	{
		_EntityDAL = new RobuxCreditActivationTaskDAL();
	}

	public RobuxCreditActivationTask(DateTime latestProcessingTime)
	{
		_EntityDAL = new RobuxCreditActivationTaskDAL();
		LatestProcessingTime = latestProcessingTime;
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

	internal static RobuxCreditActivationTask CreateNew(PremiumFeatureActivationTask premiumFeatureActivationTask)
	{
		RobuxCreditActivationTask robuxCreditActivationTask = new RobuxCreditActivationTask();
		robuxCreditActivationTask.PremiumFeatureActivationTaskID = premiumFeatureActivationTask.ID;
		robuxCreditActivationTask.Save();
		return robuxCreditActivationTask;
	}

	internal static RobuxCreditActivationTask Get(long id)
	{
		return EntityHelper.GetEntity<long, RobuxCreditActivationTaskDAL, RobuxCreditActivationTask>(EntityCacheInfo, id, () => RobuxCreditActivationTaskDAL.Get(id));
	}

	public static RobuxCreditActivationTask GetOrCreate(long premiumFeatureActivationTaskID)
	{
		return EntityHelper.GetOrCreateEntity<long, RobuxCreditActivationTask>(EntityCacheInfo, $"PremiumFeatureActivationTaskID:{premiumFeatureActivationTaskID}", () => DoGetOrCreate(premiumFeatureActivationTaskID));
	}

	private static RobuxCreditActivationTask DoGetOrCreate(long premiumFeatureActivationTaskID)
	{
		return EntityHelper.DoGetOrCreate<long, RobuxCreditActivationTaskDAL, RobuxCreditActivationTask>(() => RobuxCreditActivationTaskDAL.GetOrCreate(premiumFeatureActivationTaskID));
	}

	public static ICollection<IParallelWorkTask> LeaseTasks(Guid workerId, int leaseDurationInMinutes, int maxCount)
	{
		List<IParallelWorkTask> entities = new List<IParallelWorkTask>();
		ICollection<long> collection = RobuxCreditActivationTaskDAL.LeaseTasks(workerId, leaseDurationInMinutes, maxCount);
		DateTime leaseExpiry = DateTime.Now.AddMinutes(leaseDurationInMinutes).AddSeconds(-10.0);
		foreach (long item in collection)
		{
			RobuxCreditActivationTaskDAL entityDal = RobuxCreditActivationTaskDAL.Get(item);
			if (entityDal != null)
			{
				RobuxCreditActivationTask entity = new RobuxCreditActivationTask(leaseExpiry);
				entity.Construct(entityDal);
				CacheManager.ProcessEntityChange(entity, StateChangeEventType.Modification);
				entities.Add(entity);
			}
		}
		return entities;
	}

	public void Construct(RobuxCreditActivationTaskDAL dal)
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
		if (!(LatestProcessingTime != default(DateTime)) || !(DateTime.Now > LatestProcessingTime))
		{
			PremiumFeatureActivationTask premiumFeatureActivationTask = PremiumFeatureActivationTask.Get(PremiumFeatureActivationTaskID);
			RobuxCreditQuantityType robuxCreditQuantityType = RobuxCreditQuantityType.Get(PremiumFeature.Get(premiumFeatureActivationTask.PremiumFeatureID).RobuxCreditQuantityTypeID);
			if (robuxCreditQuantityType.ID != RobuxCreditQuantityType.NoneID)
			{
				User byAccountID = User.GetByAccountID(premiumFeatureActivationTask.AccountID);
				long balanceBefore = RobuxBalance.GetOrCreate(byAccountID.ID).Value;
				Helper.AwardRobuxPurchase(byAccountID.ID, robuxCreditQuantityType.Amount);
				WorkerID = PremiumFeatureHelper.WorkerID;
				Completed = DateTime.Now;
				Save();
				OnAccountCredited(byAccountID.ID, balanceBefore, robuxCreditQuantityType.Amount, EventArgs.Empty);
			}
		}
	}

	protected static void OnAccountCredited(long userId, long balanceBefore, long amount, EventArgs e)
	{
		RobuxCreditActivationTask.RobuxCreditPayout?.Invoke(userId, balanceBefore, amount, e);
	}
}
