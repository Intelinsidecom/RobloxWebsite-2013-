using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class BillingAccount : IRobloxEntity<int, BillingAccountDAL>, ICacheableObject<int>, ICacheableObject
{
	private BillingAccountDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.BillingAccount", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

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

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public BillingAccount()
	{
		_EntityDAL = new BillingAccountDAL();
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

	public static BillingAccount CreateNew(long accountId)
	{
		BillingAccount billingAccount = new BillingAccount();
		billingAccount.AccountID = accountId;
		billingAccount.Save();
		return billingAccount;
	}

	public static BillingAccount Get(int id)
	{
		return EntityHelper.GetEntity<int, BillingAccountDAL, BillingAccount>(EntityCacheInfo, id, () => BillingAccountDAL.Get(id));
	}

	public static BillingAccount GetByAccountID(long id)
	{
		return EntityHelper.GetEntityByLookup<int, BillingAccountDAL, BillingAccount>(EntityCacheInfo, $"AccountID:{id}", () => BillingAccountDAL.GetByAccountID(id));
	}

	public void Construct(BillingAccountDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"AccountID:{AccountID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
