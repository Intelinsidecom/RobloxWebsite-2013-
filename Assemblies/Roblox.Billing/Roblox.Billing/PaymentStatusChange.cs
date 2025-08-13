using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class PaymentStatusChange : IRobloxEntity<long, PaymentStatusChangeDAL>, ICacheableObject<long>, ICacheableObject
{
	private PaymentStatusChangeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(PaymentStatusChange).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long PaymentID
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

	internal byte? OldPaymentStatusTypeID
	{
		get
		{
			return _EntityDAL.OldPaymentStatusTypeID;
		}
		set
		{
			_EntityDAL.OldPaymentStatusTypeID = value;
		}
	}

	internal byte NewPaymentStatusTypeID
	{
		get
		{
			return _EntityDAL.NewPaymentStatusTypeID;
		}
		set
		{
			_EntityDAL.NewPaymentStatusTypeID = value;
		}
	}

	internal DateTime Created
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

	internal DateTime Updated
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

	public PaymentStatusChange()
	{
		_EntityDAL = new PaymentStatusChangeDAL();
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

	public static PaymentStatusChange CreateNew(long paymentid, byte? oldpaymentstatustypeid, byte newpaymentstatustypeid)
	{
		PaymentStatusChange paymentStatusChange = new PaymentStatusChange();
		paymentStatusChange.PaymentID = paymentid;
		paymentStatusChange.OldPaymentStatusTypeID = oldpaymentstatustypeid;
		paymentStatusChange.NewPaymentStatusTypeID = newpaymentstatustypeid;
		paymentStatusChange.Save();
		return paymentStatusChange;
	}

	internal static PaymentStatusChange Get(long id)
	{
		return EntityHelper.GetEntity<long, PaymentStatusChangeDAL, PaymentStatusChange>(EntityCacheInfo, id, () => PaymentStatusChangeDAL.Get(id));
	}

	public static ICollection<PaymentStatusChange> GetPaymentStatusChangesByPaymentID(long paymentId, long startRowIndex, int maxRows)
	{
		string collectionId = $"GetPaymentStatusChangesByPaymentID_PaymentID:{paymentId}_StartRowIndex:{startRowIndex}_MaxRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PaymentID:{paymentId}"), collectionId, () => PaymentStatusChangeDAL.GetPaymentStatusChangeIDsByPaymentID(paymentId, startRowIndex, maxRows), Get);
	}

	public static long GetTotalNumberOfPaymentStatusChangesByPaymentID(long paymentId)
	{
		string countID = $"PaymentID:{paymentId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PaymentID:{paymentId}"), countID, () => PaymentStatusChangeDAL.GetTotalNumberOfPaymentStatusChangesByPaymentID(paymentId));
	}

	public void Construct(PaymentStatusChangeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"PaymentID:{PaymentID}");
	}
}
