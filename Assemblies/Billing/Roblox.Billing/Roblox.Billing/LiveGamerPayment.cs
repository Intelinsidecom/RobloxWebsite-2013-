using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class LiveGamerPayment : IRobloxEntity<long, LiveGamerPaymentDAL>, ICacheableObject<long>, ICacheableObject
{
	private LiveGamerPaymentDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.LiveGamerPayment", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long PaymentID
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

	public byte LiveGamerPaymentStatusTypeID
	{
		get
		{
			return _EntityDAL.LiveGamerPaymentStatusTypeID;
		}
		set
		{
			_EntityDAL.LiveGamerPaymentStatusTypeID = value;
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

	public string PaymentType
	{
		get
		{
			return _EntityDAL.PaymentType;
		}
		set
		{
			_EntityDAL.PaymentType = value;
		}
	}

	public string TaxModel
	{
		get
		{
			return _EntityDAL.TaxModel;
		}
		set
		{
			_EntityDAL.TaxModel = value;
		}
	}

	public int? ExternalOrderId
	{
		get
		{
			return _EntityDAL.ExternalOrderId;
		}
		set
		{
			_EntityDAL.ExternalOrderId = value;
		}
	}

	public decimal? Tax
	{
		get
		{
			return _EntityDAL.Tax;
		}
		set
		{
			_EntityDAL.Tax = value;
		}
	}

	public string CallbackXmlContent
	{
		get
		{
			return _EntityDAL.CallbackXmlContent;
		}
		set
		{
			_EntityDAL.CallbackXmlContent = value;
		}
	}

	public string Signature
	{
		get
		{
			return _EntityDAL.Signature;
		}
		set
		{
			_EntityDAL.Signature = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public LiveGamerPayment()
	{
		_EntityDAL = new LiveGamerPaymentDAL();
	}

	public static LiveGamerPayment CreateNew(long paymentId, byte liveGamerPaymentStatusTypeID, int? externalOrderId, string paymentType, string taxModel, decimal? tax, string callbackXmlContent, string signature)
	{
		LiveGamerPayment liveGamerPayment = new LiveGamerPayment();
		liveGamerPayment.PaymentID = paymentId;
		liveGamerPayment.LiveGamerPaymentStatusTypeID = liveGamerPaymentStatusTypeID;
		liveGamerPayment.ExternalOrderId = externalOrderId;
		liveGamerPayment.PaymentType = paymentType;
		liveGamerPayment.TaxModel = taxModel;
		liveGamerPayment.Tax = tax;
		liveGamerPayment.CallbackXmlContent = callbackXmlContent;
		liveGamerPayment.Signature = signature;
		liveGamerPayment.Save();
		return liveGamerPayment;
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

	public static LiveGamerPayment Get(long id)
	{
		return EntityHelper.GetEntity<long, LiveGamerPaymentDAL, LiveGamerPayment>(EntityCacheInfo, id, () => LiveGamerPaymentDAL.Get(id));
	}

	public static LiveGamerPayment GetByPaymentId(long paymentId)
	{
		return EntityHelper.GetEntityByLookup<long, LiveGamerPaymentDAL, LiveGamerPayment>(EntityCacheInfo, "PaymentId:" + paymentId, () => LiveGamerPaymentDAL.GetByPaymentId(paymentId));
	}

	public void Construct(LiveGamerPaymentDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null && PaymentID != 0L)
		{
			yield return $"PaymentID:{PaymentID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
