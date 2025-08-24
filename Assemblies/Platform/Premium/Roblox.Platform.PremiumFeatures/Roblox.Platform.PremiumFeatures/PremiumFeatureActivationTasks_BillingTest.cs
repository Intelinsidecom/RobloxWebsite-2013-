using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class PremiumFeatureActivationTasks_BillingTest : IRobloxEntity<long, PremiumFeatureActivationTasks_BillingTestDAL>, ICacheableObject<long>, ICacheableObject
{
	private PremiumFeatureActivationTasks_BillingTestDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.PremiumFeatures.PremiumFeatureActivationTasks_BillingTest", isNullCacheable: true);

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

	public DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		set
		{
			_EntityDAL.Created = value;
		}
	}

	public DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		set
		{
			_EntityDAL.Updated = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public PremiumFeatureActivationTasks_BillingTest()
	{
		_EntityDAL = new PremiumFeatureActivationTasks_BillingTestDAL();
	}

	private static PremiumFeatureActivationTasks_BillingTest DoGet(long id)
	{
		return EntityHelper.DoGet<long, PremiumFeatureActivationTasks_BillingTestDAL, PremiumFeatureActivationTasks_BillingTest>(() => PremiumFeatureActivationTasks_BillingTestDAL.Get(id), id);
	}

	public static PremiumFeatureActivationTasks_BillingTest Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static PremiumFeatureActivationTasks_BillingTest CreateNew(int accountid, int premiumfeatureid, Guid? workerid, DateTime? completed)
	{
		PremiumFeatureActivationTasks_BillingTest premiumFeatureActivationTasks_BillingTest = new PremiumFeatureActivationTasks_BillingTest();
		premiumFeatureActivationTasks_BillingTest.AccountID = accountid;
		premiumFeatureActivationTasks_BillingTest.PremiumFeatureID = premiumfeatureid;
		premiumFeatureActivationTasks_BillingTest.WorkerID = workerid;
		premiumFeatureActivationTasks_BillingTest.Completed = completed;
		premiumFeatureActivationTasks_BillingTest.Save();
		return premiumFeatureActivationTasks_BillingTest;
	}

	public static PremiumFeatureActivationTasks_BillingTest CreateNew(int accountID, PremiumFeature premiumFeature)
	{
		PremiumFeatureActivationTasks_BillingTest premiumFeatureActivationTasks_BillingTest = new PremiumFeatureActivationTasks_BillingTest();
		premiumFeatureActivationTasks_BillingTest.AccountID = accountID;
		premiumFeatureActivationTasks_BillingTest.PremiumFeatureID = premiumFeature.ID;
		premiumFeatureActivationTasks_BillingTest.Save();
		return premiumFeatureActivationTasks_BillingTest;
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

	public void Construct(PremiumFeatureActivationTasks_BillingTestDAL dal)
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
}
