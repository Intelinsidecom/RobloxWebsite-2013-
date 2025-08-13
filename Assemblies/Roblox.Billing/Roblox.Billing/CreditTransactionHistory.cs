using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class CreditTransactionHistory : IRobloxEntity<long, CreditTransactionHistoryDAL>, ICacheableObject<long>, ICacheableObject
{
	private CreditTransactionHistoryDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.CreditTransactionHistory", isNullCacheable: true);

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

	public int TransactionTypeID
	{
		get
		{
			return _EntityDAL.TransactionTypeID;
		}
		set
		{
			_EntityDAL.TransactionTypeID = value;
		}
	}

	public decimal Amount
	{
		get
		{
			return _EntityDAL.Amount;
		}
		set
		{
			_EntityDAL.Amount = value;
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

	public string TransactionID
	{
		get
		{
			return _EntityDAL.TransactionID;
		}
		set
		{
			_EntityDAL.TransactionID = value;
		}
	}

	public int? TransactionOriginTypeID
	{
		get
		{
			return _EntityDAL.TransactionOriginTypeID;
		}
		set
		{
			_EntityDAL.TransactionOriginTypeID = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public CreditTransactionHistory()
	{
		_EntityDAL = new CreditTransactionHistoryDAL();
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

	public static CreditTransactionHistory CreateNew(long accountid, int transactiontypeid, decimal amount, string transactionid, int? transactionorigintypeid)
	{
		CreditTransactionHistory creditTransactionHistory = new CreditTransactionHistory();
		creditTransactionHistory.AccountID = accountid;
		creditTransactionHistory.TransactionTypeID = transactiontypeid;
		creditTransactionHistory.Amount = amount;
		creditTransactionHistory.TransactionID = transactionid;
		creditTransactionHistory.TransactionOriginTypeID = transactionorigintypeid;
		creditTransactionHistory.Save();
		return creditTransactionHistory;
	}

	public static CreditTransactionHistory Get(long id)
	{
		return EntityHelper.GetEntity<long, CreditTransactionHistoryDAL, CreditTransactionHistory>(EntityCacheInfo, id, () => CreditTransactionHistoryDAL.Get(id));
	}

	public static void Submit(long accountId, int transactionTypeId, string transactionId, int transactionOriginTypeId, decimal amount)
	{
		RobloxThreadPool.QueueUserWorkItem(new CreditTransactionHistory
		{
			AccountID = accountId,
			TransactionTypeID = transactionTypeId,
			TransactionID = transactionId,
			TransactionOriginTypeID = transactionOriginTypeId,
			Amount = amount
		}.Save);
	}

	public void Construct(CreditTransactionHistoryDAL dal)
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
