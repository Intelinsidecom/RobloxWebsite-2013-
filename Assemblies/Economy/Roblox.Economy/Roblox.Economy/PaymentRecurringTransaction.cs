using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy;

public class PaymentRecurringTransaction : IRobloxEntity<long, PaymentRecurringTransactionDAL>, ICacheableObject<long>, ICacheableObject
{
	private PaymentRecurringTransactionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PaymentRecurringTransaction).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long PaymentId
	{
		get
		{
			return _EntityDAL.PaymentID;
		}
		set
		{
			_EntityDAL.PaymentID = value;
		}
	}

	public string RecurringTransactionId
	{
		get
		{
			return _EntityDAL.RecurringTransactionID;
		}
		set
		{
			_EntityDAL.RecurringTransactionID = value;
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

	public PaymentRecurringTransaction()
	{
		_EntityDAL = new PaymentRecurringTransactionDAL();
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
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	internal static PaymentRecurringTransaction Get(long id)
	{
		return EntityHelper.GetEntity<long, PaymentRecurringTransactionDAL, PaymentRecurringTransaction>(EntityCacheInfo, id, () => PaymentRecurringTransactionDAL.Get(id));
	}

	private static ICollection<PaymentRecurringTransaction> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, PaymentRecurringTransactionDAL, PaymentRecurringTransaction>(ids, EntityCacheInfo, PaymentRecurringTransactionDAL.MultiGet);
	}

	public static PaymentRecurringTransaction CreateNew(long paymentId, string recurringTransactionId)
	{
		PaymentRecurringTransaction paymentRecurringTransaction = new PaymentRecurringTransaction();
		paymentRecurringTransaction.PaymentId = paymentId;
		paymentRecurringTransaction.RecurringTransactionId = recurringTransactionId;
		paymentRecurringTransaction.Save();
		return paymentRecurringTransaction;
	}

	public static PaymentRecurringTransaction GetByPaymentId(long paymentId)
	{
		return EntityHelper.GetEntityByLookup<long, PaymentRecurringTransactionDAL, PaymentRecurringTransaction>(EntityCacheInfo, $"PaymentID:{paymentId}", () => PaymentRecurringTransactionDAL.GetPaymentRecurringTransactionByPaymentID(paymentId));
	}

	public static PaymentRecurringTransaction GetByRecurringTransactionId(string recurringTransactionId)
	{
		return EntityHelper.GetEntityByLookup<long, PaymentRecurringTransactionDAL, PaymentRecurringTransaction>(EntityCacheInfo, $"RecurringTransactionID:{recurringTransactionId}", () => PaymentRecurringTransactionDAL.GetPaymentRecurringTransactionByRecurringTransactionID(recurringTransactionId));
	}

	public void Construct(PaymentRecurringTransactionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"PaymentID:{PaymentId}";
		yield return $"RecurringTransactionID:{RecurringTransactionId}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
