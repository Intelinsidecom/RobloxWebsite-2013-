using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class PaymentStatusTypeChangeReasonType : IRobloxEntity<int, PaymentStatusTypeChangeReasonTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private PaymentStatusTypeChangeReasonTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(PaymentStatusTypeChangeReasonType).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal byte PaymentStatusTypeID
	{
		get
		{
			return _EntityDAL.PaymentStatusTypeID;
		}
		set
		{
			_EntityDAL.PaymentStatusTypeID = value;
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

	public PaymentStatusTypeChangeReasonType()
	{
		_EntityDAL = new PaymentStatusTypeChangeReasonTypeDAL();
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

	private static PaymentStatusTypeChangeReasonType CreateNew(byte paymentstatustypeid, byte paymentstatuschangereasontypeid)
	{
		PaymentStatusTypeChangeReasonType paymentStatusTypeChangeReasonType = new PaymentStatusTypeChangeReasonType();
		paymentStatusTypeChangeReasonType.PaymentStatusTypeID = paymentstatustypeid;
		paymentStatusTypeChangeReasonType.PaymentStatusChangeReasonTypeID = paymentstatuschangereasontypeid;
		paymentStatusTypeChangeReasonType.Save();
		return paymentStatusTypeChangeReasonType;
	}

	internal static PaymentStatusTypeChangeReasonType Get(int id)
	{
		return EntityHelper.GetEntity<int, PaymentStatusTypeChangeReasonTypeDAL, PaymentStatusTypeChangeReasonType>(EntityCacheInfo, id, () => PaymentStatusTypeChangeReasonTypeDAL.Get(id));
	}

	public static ICollection<PaymentStatusTypeChangeReasonType> GetPaymentStatusTypeChangeReasonTypesByPaymentStatusTypeID(byte paymentStatusTypeId, int startRowIndex, int maxRows)
	{
		string collectionId = $"GetPaymentStatusTypeChangeReasonTypesByPaymentID_PaymentID:{paymentStatusTypeId}_StartRowIndex:{startRowIndex}_MaxRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PaymentStatusTypeID:{paymentStatusTypeId}"), collectionId, () => PaymentStatusTypeChangeReasonTypeDAL.GetPaymentStatusTypeChangeReasonTypeIDsByPaymentStatusTypeID(paymentStatusTypeId, startRowIndex, maxRows), Get);
	}

	public static int GetTotalNumberOfPaymentStatusTypeChangeReasonTypesByPaymentStatusTypeID(byte paymentStatusTypeId)
	{
		string countID = $"PaymentStatusTypeID:{paymentStatusTypeId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PaymentStatusTypeID:{paymentStatusTypeId}"), countID, () => PaymentStatusTypeChangeReasonTypeDAL.GetTotalNumberOfPaymentStatusTypeChangeReasonTypesByPaymentStatusTypeID(paymentStatusTypeId));
	}

	public void Construct(PaymentStatusTypeChangeReasonTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"PaymentStatusTypeID:{PaymentStatusTypeID}");
	}
}
