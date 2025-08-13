using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class PaymentStatusChangeReason : IRobloxEntity<long, PaymentStatusChangeReasonDAL>, ICacheableObject<long>, ICacheableObject
{
	private PaymentStatusChangeReasonDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(PaymentStatusChangeReason).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long PaymentStatusChangeID
	{
		get
		{
			return _EntityDAL.PaymentStatusChangeID;
		}
		set
		{
			_EntityDAL.PaymentStatusChangeID = value;
		}
	}

	public long? AccountID
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

	public byte PaymentStatusChangeReasonTypeID
	{
		get
		{
			return _EntityDAL.PaymentStatusChangeReasonTypeID;
		}
		set
		{
			_EntityDAL.PaymentStatusChangeReasonTypeID = value;
		}
	}

	public string Notes
	{
		get
		{
			return _EntityDAL.Notes;
		}
		set
		{
			_EntityDAL.Notes = value;
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

	public PaymentStatusChangeReason()
	{
		_EntityDAL = new PaymentStatusChangeReasonDAL();
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

	public static PaymentStatusChangeReason CreateNew(long paymentstatuschangeid, long? accountid, byte paymentstatuschangereasontypeid, string notes)
	{
		PaymentStatusChangeReason paymentStatusChangeReason = new PaymentStatusChangeReason();
		paymentStatusChangeReason.PaymentStatusChangeID = paymentstatuschangeid;
		paymentStatusChangeReason.AccountID = accountid;
		paymentStatusChangeReason.PaymentStatusChangeReasonTypeID = paymentstatuschangereasontypeid;
		paymentStatusChangeReason.Notes = notes;
		paymentStatusChangeReason.Save();
		return paymentStatusChangeReason;
	}

	public static PaymentStatusChangeReason Get(long id)
	{
		return EntityHelper.GetEntity<long, PaymentStatusChangeReasonDAL, PaymentStatusChangeReason>(EntityCacheInfo, id, () => PaymentStatusChangeReasonDAL.Get(id));
	}

	public static PaymentStatusChangeReason GetByPaymentStatusChangeId(long paymentStatusChangeId)
	{
		return EntityHelper.GetEntityByLookup<long, PaymentStatusChangeReasonDAL, PaymentStatusChangeReason>(EntityCacheInfo, $"PaymentStatusChangeID:{paymentStatusChangeId}", () => PaymentStatusChangeReasonDAL.GetByPaymenstStatusChangeId(paymentStatusChangeId));
	}

	public void Construct(PaymentStatusChangeReasonDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"PaymentStatusChangeID:{PaymentStatusChangeID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
